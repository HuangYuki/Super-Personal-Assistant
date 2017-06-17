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
	public partial class LoginForm : Form
	{
		ClientSocket _clientsocket;
		StrHandler msgHandler;
		ConectionSetting createConnection;
		public LoginForm()
		{
			InitializeComponent();

			msgHandler = this.addMsg;
			createConnection = new ConectionSetting();
			secretTextBox.PasswordChar = '*';  //輸入密碼時顯示為"*"
		}

		private void clickLogInButton(object sender, EventArgs e)
		{
			string _account = accountTextBox.Text;
			string _secret = secretTextBox.Text;
			if (_account == "" || _secret == "" || !accountTextBox.Text.IsNaturalNumber() || !secretTextBox.Text.IsNaturalNumber())
			{
				MessageBox.Show("帳戶或密碼格式不符！！！");
			}
			else
			{
				string dataString = "1" + " " + _account + " " + _secret;
				sentData(dataString);
				chatRoomManagement reg = new chatRoomManagement(_clientsocket);
				reg.Show();

			}
			//foreach (Control item in Controls)
			//{
			//	item.Visible = false;
			//}
			//logInSuccessLabel.Visible = true;
		}

		private void clickRegisterButton(object sender, EventArgs e)
		{

			RegisterForm reg = new RegisterForm();
			reg.ShowDialog();
		}

		public void sentData(string userData) //"1 帳號 密碼"
		{
			//MessageBox.Show(userData);


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
			MessageBox.Show(msg == "OK" ? "登入成功" : "登入失敗");
			return "OK";
		}
	}
}
