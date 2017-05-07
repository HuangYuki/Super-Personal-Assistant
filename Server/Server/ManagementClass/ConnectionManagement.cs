using Server.Class;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.ManagementClass
{
    class ConnectionManagement
    {
        List<ClientAccount> _accountList = new List<ClientAccount>();
        DataManagement _datamanagement = new DataManagement();


        public ConnectionManagement()
        {
            InitializeAccount();
        }

        public void InitializeAccount() //搬到ConnectionManagement
        {
            string str = "0 aaaa bbbb fuck";
            StreamReader sr = new StreamReader(@"../../DataStorage/Account.txt");
            while (!sr.EndOfStream)
            {
                String[] words = null;
                ClientAccount account = new ClientAccount();
                string line = sr.ReadLine();

                words = _datamanagement.seperateData(1, line);
                account.Id = words[0];
                account.Account = words[1];
                account.Passward = words[2];
                account.Name = words[3];
                _accountList.Add(account);
            }
            sr.Close();
            if(!_datamanagement.doDataManagement(str, _accountList))
            {
                Console.WriteLine("false");
            }
            //Console.WriteLine(_accountList.Count);
            _datamanagement.doDataManagement(str, _accountList);
            Console.WriteLine(_accountList.Count);
        }

        

    }
}
