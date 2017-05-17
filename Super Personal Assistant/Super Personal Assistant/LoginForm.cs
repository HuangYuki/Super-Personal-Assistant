using Super_Personal_Assistant;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Super_Personal_Assistant
{
    public partial class LoginForm : Form
    {
        ClientSocket _clientsocket;
        ConectionSetting createConnection;
        public LoginForm()
        {
            InitializeComponent();

            createConnection = new ConectionSetting();
            secretTextBox.PasswordChar = '*';
        }

        private void clickLogInButton(object sender, EventArgs e)
        {
            string _account = accountTextBox.Text;
            string _secret = secretTextBox.Text;
            if (_account == "" || _secret == "" || !accountTextBox.Text.IsNaturalNumber() || !secretTextBox.Text.IsNaturalNumber())
            {
                MessageBox.Show("帳戶或密碼格式不符！！！");
            }

            foreach (Control item in Controls)
            {
                item.Visible = false;
            }
            logInSuccessLabel.Visible = true;
        }

        private void clickRegisterButton(object sender, EventArgs e)
        {

            RegisterForm reg = new RegisterForm();
            reg.ShowDialog();
        }
    }
}
