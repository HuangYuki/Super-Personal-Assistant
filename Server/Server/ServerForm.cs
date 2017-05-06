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
        List<ClientAccount> _accountList = new List<ClientAccount>();
        DataManagement _datamanagement = new DataManagement();

        public ServerForm()
        {
            InitializeComponent();
            InitializeAccount();
            char a = '1';
            int b = 0;
            int c = b - (a - '0');
            Console.WriteLine(c);
        }

        public void InitializeAccount() //搬到ConnectionManagement
        {
            StreamReader sr = new StreamReader(@"../../DataStorage/Account.txt");
            while (!sr.EndOfStream)
            {
                String[] words = null;
                ClientAccount account = new ClientAccount();
                string line = sr.ReadLine();

                Console.WriteLine(line);
                words = _datamanagement.seperateData(1, line);
                account.Id = words[0];
                Console.WriteLine(account.Id);
                account.Account = words[1];
                Console.WriteLine(account.Account);
                account.Passward = words[2];
                Console.WriteLine(account.Passward);
                account.Name = words[3];
                Console.WriteLine(account.Name);
                _accountList.Add(account);
                Console.WriteLine(_accountList.Count);
            }
            sr.Close();
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
