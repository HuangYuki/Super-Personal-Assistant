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

        public InputForm()
        {
            InitializeComponent();
        }

        public InputForm(DateTime di)
        {
            InitializeComponent();
            d = di;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //這要修改為 存到資料庫
            MainForm mf = (MainForm)this.Owner;
            mf.AddActivity(new Activity(d, titleTextBox.Text, bodyRichTextBox.Text));
            this.Close();
        }
    }
}
