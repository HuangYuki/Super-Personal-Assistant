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

namespace chatroomtest
{
	public partial class chatRoomManagement : Form
	{

		ClientSocket _clientsocket;
		StrHandler msgHandler;
		public String chatInputTemp = "";
		
		public chatRoomManagement()
		{
			InitializeComponent();

			msgHandler = this.addMsg;
		}

		public chatRoomManagement(ClientSocket clientsocket)
		{
			InitializeComponent();
			_clientsocket = clientsocket;
		}


		private void inputTextBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				chatInputTemp = "You Entered: " + inputTextBox.Text;
				MessageBox.Show(chatInputTemp);
				inputTextBox.Text = "";
			}
		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
			richTextBox1.SelectionStart = richTextBox1.TextLength;

			// Scrolls the contents of the control to the current caret position.
			richTextBox1.ScrollToCaret();
		}

		internal void Show(ClientSocket clientsocket)
		{
			throw new NotImplementedException();
		}

		private void sendInvitebutton_Click(object sender, EventArgs e)
		{
			string _friendaccount = friendAccountTextBox.Text;

			if (_friendaccount == "" || !friendAccountTextBox.Text.IsNaturalNumber())
			{
				MessageBox.Show("帳戶格式不符！！！");
			}
			else
			{
				string dataString = "2" + " " + _friendaccount;
				sentData(dataString);
				chatRoomManagement reg = new chatRoomManagement(_clientsocket);
				reg.Show();

			}
		}

		public void sentData(string userData) //"2 帳號"
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
			MessageBox.Show(msg == "OK" ? "寄送成功" : "查詢不到該帳號");
			return "OK";
		}
	}
}
