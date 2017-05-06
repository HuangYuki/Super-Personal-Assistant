using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class ServerForm : Form
    {
        public ServerForm()
        {
            InitializeComponent();
            char a = '1';
            int b = 0;
            int c = b - (a - '0');
            Console.WriteLine(c);
        }

        private void ServerForm_Load(object sender, EventArgs e)
        {
            char a = '1';
            int b = 0;
            int c = b - (a - '0');
            Console.WriteLine(c);

        }
    }
}
