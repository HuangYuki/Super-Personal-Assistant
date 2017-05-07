using Server.Class;
using Server.ManagementClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class ServerForm : Form
    {
        ConnectionManagement chatServer = null;

        public ServerForm()
        {
            InitializeComponent();
            chatServer = new ConnectionManagement();
            chatServer.run();
        }

        private void ServerForm_Load(object sender, EventArgs e)
        {


        }
    }
}
