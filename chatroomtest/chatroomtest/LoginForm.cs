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

		List<String> friendRequest = new List<string>();
		List<String> friendList = new List<string>();
		String _account = "";
		String _password = "";
		String chatInputTemp = "";  //要寄出的聊天訊息暫存

		public LoginForm()
		{
			InitializeComponent();

			this.tabPage2.Parent = null;  //hide
										  //this.tabPage1.Parent = this.tabControl1; //show
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
			if (msg[0] == '1')
			{
				if (msg != "1_FALSE")
				{
					MessageBox.Show("登入成功");
					_myAccount.Account = _account;
					_myAccount.Passward = _password;
					_myAccount.Name = seperateGetData(msg);
					this.tabPage1.Parent = null;  //hide
					this.tabPage2.Parent = this.tabControl1; //show
					tabControl1.SelectedTab = tabPage2;
					userLabel.Text = userLabel.Text + " " + _myAccount.Name;
				}
				else
				{
					MessageBox.Show("登入失敗");
				}
			}
			else if (msg[0] == '3')
			{
				if (msg == "3_OK")  //該user存在
				{
					MessageBox.Show(_account + "邀請已寄出");
				}
				else if (msg == "3_FALSE") //該user account不存在
				{
					MessageBox.Show("邀請寄送失敗");
				}
				else if (msg == "3_EXIST")
				{
					MessageBox.Show("好友已存在！");
				}
				else  //已收到該user好友邀請
				{

					friendRequest.Add(msg);
					MessageBox.Show(_account + "收到邀請");

					initilizeRow(friendRequestdataGridView);
					friendRequestdataGridView.Rows.Clear();
					for (int i = 0; i < friendRequest.Count; i++)
					{
						String[] row = new String[] { seperateGetData(friendRequest[i]), "接受邀請", "拒絕邀請" };
						friendRequestdataGridView.Rows.Add(row);
						friendRequestdataGridView.AutoResizeColumns();
					}
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
				string dataString = "3" + "_" + _friendaccount;
				sentData(dataString);
			}
		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)  //歷史訊息顯示
		{
			richTextBox1.SelectionStart = richTextBox1.TextLength;

			// Scrolls the contents of the control to the current caret position.
			richTextBox1.ScrollToCaret();
		}

		private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				chatInputTemp = "You Entered: " + inputTextBox.Text;
				MessageBox.Show(chatInputTemp);
				inputTextBox.Text = "";
			}
		}

		public String seperateGetData(string data) //分離資料
		{
			char space = '_';
			string[] words = null;

			words = data.Split(space);

			return words[1];
		}

		private void friendRequestdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 1)
			{
				sentData(friendRequest[e.RowIndex]);  //接受對方邀請並傳給server
				friendRequest.RemoveAt(e.RowIndex);  //從好友邀請list中刪除

				initilizeRow(friendRequestdataGridView);
				//friendRequestdataGridView.Rows.Clear();
				//for (int i = 0; i < friendRequest.Count; i++)
				//{
				//	String[] row = new String[] { friendRequest[i], "接受邀請", "拒絕邀請" };
				//	friendRequestdataGridView.Rows.Add(row);
				//	friendRequestdataGridView.AutoResizeColumns();
				//}
			}
		}
		public void initilizeRow(DataGridView datagridview)
		{
			datagridview.Rows.Clear();
			for (int i = 0; i < friendRequest.Count; i++)
			{
				String[] row = new String[] { friendRequest[i], "接受邀請", "拒絕邀請" };
				datagridview.Rows.Add(row);
				datagridview.AutoResizeColumns();
			}
		}
	}
}
