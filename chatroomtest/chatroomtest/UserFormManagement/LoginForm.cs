using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chatroomtest.UserFormManagement
{
	public partial class LoginForm : Form
	{
		RegisterForm reg = new RegisterForm();
		public LoginForm()
		{
			InitializeComponent();

			secretTextBox.PasswordChar = '*';
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string _account = accountTextBox.Text;
			string _secret = secretTextBox.Text;
			if (_account == "" || _secret == "" || !reg.IsNatural_Number(accountTextBox.Text) || !reg.IsNatural_Number(secretTextBox.Text))
			{
				MessageBox.Show("帳戶或密碼格式不符！！！");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			reg.ShowDialog();
		}
	}
}
