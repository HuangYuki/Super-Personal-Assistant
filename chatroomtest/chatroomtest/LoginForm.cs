using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using chatroomtest.ManagementClass;
using Server.Class;

namespace chatroomtest
{
	public partial class LoginForm : Form
	{
		ClientAccount _myAccount;
		ClientSocket _clientsocket;
		StrHandler msgHandler;
		ConectionSetting createConnection;

		List<String> friendRequestList = new List<string>();
		List<String> friendAccountList = new List<string>();
		List<String> messageList = new List<string>();
		String _account = "";
		String _password = "";
		String chatInputTemp = "";  //要寄出的聊天訊息暫存
		String chatFriend = "";  //要聊天的好友
		String newFriend = "";
		String friendAccountTemp = "";  //暫存欲加入好友帳號

		public LoginForm()
		{
			InitializeComponent();

			//this.tabPage2.Parent = null;  //hide
			_myAccount = new ClientAccount();
			msgHandler = this.addMsg;
			createConnection = new ConectionSetting();
			secretTextBox.PasswordChar = '*';  //輸入密碼時顯示為"*"
		}

		private void clickLogInButton(object sender, EventArgs e)  //"1_帳號_密碼"
		{
			_account = accountTextBox.Text;
			_password = secretTextBox.Text;
			if (_account == "" || _password == "" || !accountTextBox.Text.IsNaturalNumber() || !secretTextBox.Text.IsNaturalNumber())
			{
				MessageBox.Show("帳戶或密碼格式不符！！！");
			}
			else
			{
				string dataString = "1" + "_" + _account + "_" + _password;
				sentData(dataString);
			}
		}

		private void clickRegisterButton(object sender, EventArgs e)
		{

			RegisterForm reg = new RegisterForm();
			reg.ShowDialog();
		}

		public void sentData(string userData)
		{

			if (_clientsocket == null)
			{
				_clientsocket = ClientSocket.connect(ConectionSetting.serverIp);
				_clientsocket.newListener(processMsgComeIn);
			}
			_clientsocket.send(userData);

			foreach (Control item in Controls)
			{
				item.Text = item is TextBox ? "" : item.Text; //如果是textbox那就清空否則保持原狀
			}
		}

		public String processMsgComeIn(String msg)
		{
			this.Invoke(msgHandler, new Object[] { msg });
			return "OK";
		}

		public String addMsg(String msg)
		{
			if (msg[0] == '1')  //判斷登入是否成功
			{
				if (msg != "1_FALSE")
				{
					MessageBox.Show("登入成功");
					_myAccount.Account = _account;
					_myAccount.Passward = _password;
					_myAccount.Name = seperateGetData(msg)[1];

					this.tabPage1.Parent = null;  //隱藏第一分頁
					this.tabPage2.Parent = this.tabControl1; //顯示第二分頁
					tabControl1.SelectedTab = tabPage2;

					userLabel.Text = userLabel.Text + " " + _myAccount.Name;
				}
				else
				{
					MessageBox.Show("登入失敗");
				}
			}
			else if (msg[0] == '2')
			{
				if (msg == "2_OK")
				{
					
					loadingHistoryMessage();
					inputTextBox.Enabled = true;
				}
				else
				{
					messageList.Add(seperateGetData(msg)[0]);
				}
			}
			else if (msg[0] == '3')  //判斷好友新增
			{
				if (msg == "3_OK")  //該user存在
				{
					MessageBox.Show(_account + "邀請已寄出");

					friendAccountList.Add(newFriend);  // 成功送出好友後先新增到好友列表

					friendDataGridView.Rows.Clear();
					for (int i = 0; i < friendAccountList.Count; i++)
					{
						String[] row = new String[] { friendAccountList[i] };
						friendDataGridView.Rows.Add(row);
						friendDataGridView.AutoResizeColumns();
					}
				}
				else if (msg == "3_FALSE") //該user account不存在
				{
					MessageBox.Show("邀請寄送失敗");
				}
				else if (msg == "3_EXIST")
				{
					MessageBox.Show("好友已存在！");
				}
				else if (msg[0] == '3' && msg[1] == '1')
				{

				}
				else  //已收到該user好友邀請
				{
					friendRequestList.Add(seperateGetData(msg)[1]);
					MessageBox.Show(_account + "收到邀請");

					initilizeRequestRow();
				}
			}
			else if (msg[0] == '4')
			{
				if (msg == "4_OK")
				{
					MessageBox.Show("收到訊息");
				}
				else if (msg == "4_FALSE")
				{
					MessageBox.Show("接收訊息失敗");
				}
				else if (msg == "4_NOTFOUND")
				{
					MessageBox.Show("該用戶不在線上");
				}
				else  //接收對方訊息 4_訊息內容
				{
					//MessageBox.Show("test");
					messageList.Add(seperateGetData(msg)[2]);
					chatInputTemp = chatFriend + " : " + seperateGetData(msg)[1];
					messageList.Add(chatInputTemp);
					messageRichTextBox.Text += chatInputTemp + "\n";
					chatInputTemp = "";
				}
			}
			return "OK";
		}

		private void sendInvitebutton_Click(object sender, EventArgs e)  //寄送好友邀請 "3_好友帳號"
		{
			string _friendaccount = friendAccountTextBox.Text;

			if (_friendaccount == "" || !friendAccountTextBox.Text.IsNaturalNumber())
			{
				MessageBox.Show("帳戶格式不符！！！");
			}
			else
			{
				friendAccountTemp = _friendaccount;
				string dataString = "3" + "_" + _friendaccount;
				newFriend = _friendaccount;
				sentData(dataString);

				friendAccountTextBox.Clear();
			}
		}

		private void inputTextBox_KeyDown(object sender, KeyEventArgs e)  //傳送訊息   4_我的帳號_朋友帳號_訊息內容
		{
			if (e.KeyCode == Keys.Enter)
			{
				chatInputTemp = inputTextBox.Text;
				//MessageBox.Show(chatInputTemp);
				messageList.Add(chatInputTemp);
				messageRichTextBox.Text += "You : " +  chatInputTemp + "\n";
				sentData("4_" + _myAccount.Account + "_" + chatFriend + "_" + chatInputTemp);  //要改成朋友帳號
				inputTextBox.Clear();  //清空訊息欄
				SendKeys.Send("{BACKSPACE}"); //解決清空之後的跳行錯誤
				chatInputTemp = "";  //清空聊天暫存
			}
			
		}

		public String[] seperateGetData(string data) //分離資料
		{
			char space = '_';
			string[] words = null;

			words = data.Split(space);

			return words;
		}

		private void friendRequestdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 1)
			{
				sentData("3_"+friendRequestList[e.RowIndex]);  //接受對方邀請並傳給server
				newFriend = friendRequestList[e.RowIndex];

				//friendAccountList.Add(friendRequestList[e.RowIndex]);  //新增好友到好友列表
				//更新好友列表
				friendDataGridView.Rows.Clear();  
				for (int i = 0; i < friendAccountList.Count; i++)
				{
					String[] row = new String[] {friendAccountList[i]};
					friendDataGridView.Rows.Add(row);
					friendDataGridView.AutoResizeColumns();
				}

				friendRequestList.RemoveAt(e.RowIndex);  //從好友邀請list中刪除
				initilizeRequestRow();
			}
		}
		public void initilizeRequestRow()   //更新好友邀請列表
		{
			friendRequestdataGridView.Rows.Clear();
			for (int i = 0; i < friendRequestList.Count; i++)
			{
				String[] row = new String[] { friendRequestList[i], "接受邀請", "拒絕邀請" };
				friendRequestdataGridView.Rows.Add(row);
				friendRequestdataGridView.AutoResizeColumns();
			}
		}


		public void loadingHistoryMessage()
		{
			for (int i = 0; i < messageList.Count; i++)
			{
				messageRichTextBox.Text += messageList[i] + "\n";
			}
		}

		private void friendDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)  //2_我的帳號_好友帳號
		{
			if (e.ColumnIndex == 0 && e.RowIndex >= 0)
			{
				Console.WriteLine("123");
				sentData("2_" + _myAccount.Account + "_" + friendAccountList[e.RowIndex]);
				chatFriend = friendAccountList[e.RowIndex];  //點選的好友帳號名稱
				inputTextBox.Enabled = false;  //點選好友時先讓server將聊天歷史紀錄loading完後再讓使用者聊天
				messageList.Clear(); //先清空先前的訊息列表
			}
			else
			{
				Console.WriteLine("456");
			}
		}
	}
}
