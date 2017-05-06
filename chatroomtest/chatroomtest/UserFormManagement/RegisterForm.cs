using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chatroomtest
{
	public partial class RegisterForm : Form
	{
		public RegisterForm()
		{
			InitializeComponent();

			secretTextBox.PasswordChar = '*';
		}

		private void button1_Click(object sender, EventArgs e) 
		{
			checkFormat();
		}

		public void sentData(string userData) //"0 帳號 密碼 姓名 "
		{
			//MessageBox.Show(userData);
			MessageBox.Show("註冊完成");
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
				MessageBox.Show("帳戶或密碼格式不符！！！");
			}
			else
			{
				string dataString = "0 " + _name + " " + _account + " " + _secret + " ";
				sentData(dataString);
			}
		}

		public bool IsNatural_Number(string str)
		{
			System.Text.RegularExpressions.Regex reg1 = new System.Text.RegularExpressions.Regex(@"^[A-Za-z0-9]+$");
			return reg1.IsMatch(str);
		}
	}
}
