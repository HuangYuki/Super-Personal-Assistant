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
	public partial class RegisterForm : Form
	{
		ClientSocket _clientsocket;
		StrHandler msgHandler;

		public RegisterForm()
		{
			InitializeComponent();

			msgHandler = this.addMsg;
			secretTextBox.PasswordChar = '*';
		}

		private void clickSentButton(object sender, EventArgs e)
		{
			checkFormat();
		}

		public void sentData(string userData) //"0 帳號 密碼 姓名"
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

		public void checkFormat()
		{
			string _name = nameTextBox.Text;
			string _account = accountTextBox.Text;
			string _secret = secretTextBox.Text;

			if (_name == "" || !(IsNatural_Number(_name)))
			{
				MessageBox.Show("名字輸入格式不符！！！");
			}
			else if (_account == "" || _secret == "" || !(IsNatural_Number(_account)) || !IsNatural_Number(_secret))
			{
				_account.IsNaturalNumber();
				MessageBox.Show("帳戶或密碼格式不符！！！");
			}
			else
			{
				string dataString = "0" + " " + _account + " " + _secret + " " + _name;
				sentData(dataString);
			}
		}

		public bool IsNatural_Number(string str)
		{
			System.Text.RegularExpressions.Regex reg1 = new System.Text.RegularExpressions.Regex(@"^[A-Za-z0-9]+$");
			return reg1.IsMatch(str);
		}

		public String processMsgComeIn(String msg)
		{
			this.Invoke(msgHandler, new Object[] { msg });
			return "OK";
		}

		public String addMsg(String msg)
		{
			MessageBox.Show(msg == "OK" ? "註冊成功" : "註冊失敗");
			return "OK";
		}
	}
}
