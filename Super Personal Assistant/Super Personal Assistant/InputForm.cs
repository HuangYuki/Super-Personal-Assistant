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
        private DateTime _d;
        private int _type;
        private int _id;

        public InputForm()
        {
            InitializeComponent();
        }

        public InputForm(DateTime dt,int id)
        {
            InitializeComponent();
            _d = dt;
            _id = id;
        }

        public void SetType(int type)
        {
            _type = type;
            switch (_type)
            {
                case MainForm.ACCOUNT_ADD:
                    titleTextBox.Text = "100";
                    numericUpDown1.Visible = false;
                    numericUpDown2.Visible = false;
                    break;
                case MainForm.SCHEDULE:

                    break;
                case MainForm.ACCOUNT_EDIT:
                    titleTextBox.Text = "100";
                    numericUpDown1.Visible = false;
                    numericUpDown2.Visible = false;
                    break;
                default:
                    break;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //這要修改為 存到資料庫
            MainForm mf = (MainForm)this.Owner;
            switch (_type)
            {
                case MainForm.SCHEDULE:
                    _d = _d.AddHours(double.Parse(numericUpDown1.Value.ToString()));
                    _d = _d.AddMinutes(double.Parse(numericUpDown2.Value.ToString()));
                    mf.AddActivity(new Activity(_d, titleTextBox.Text, bodyRichTextBox.Text,_id));
                    break;
                case MainForm.ACCOUNT_ADD:
                    mf.AddAccount(new AccountItem(_id, int.Parse(titleTextBox.Text),bodyRichTextBox.Text,_d));
                    break;
                case MainForm.ACCOUNT_EDIT:
                    mf.EditAccount(_id, int.Parse(titleTextBox.Text), bodyRichTextBox.Text);
                    break;
                default:
                    break;
            }
            this.Close();
        }

    }
}
