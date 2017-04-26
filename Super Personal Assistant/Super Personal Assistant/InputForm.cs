using Super_Personal_Assistant.Class;
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
    public partial class InputForm : Form
    {
        private DateTime d;
        private int _type;

        public InputForm()
        {
            InitializeComponent();
        }

        public InputForm(DateTime di)
        {
            InitializeComponent();
            d = di;
        }

        public void SetType(int type)
        {
            _type = type;
            if (MainForm.ACCOUNT == type)
            {
                titleTextBox.Text = "100";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //這要修改為 存到資料庫
            MainForm mf = (MainForm)this.Owner;
            switch (_type)
            {
                case MainForm.SCHEDULE:
                    mf.AddActivity(new Activity(d, titleTextBox.Text, bodyRichTextBox.Text));
                    break;
                case MainForm.ACCOUNT:
                    mf.AddAccount(new Account(int.Parse(titleTextBox.Text),bodyRichTextBox.Text,d));
                    break;
                default:
                    break;
            }
            this.Close();
        }

    }
}
