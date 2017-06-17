using Server.Class;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using static Server.Class.ChatLib;

namespace Server.ManagementClass
{
    class ConnectionManagement
    {
        List<ClientAccount> _accountList = new List<ClientAccount>();
        DataManagement _datamanagement = new DataManagement();
        List<ChatSocket> _clientList = new List<ChatSocket>();
        

        public ConnectionManagement()
        {
            InitializeAccount();
        }

        public void InitializeAccount() //初始化所有帳號
        {
            //string str = "0 aaaa bbbb fuck"; //新帳號
            StreamReader sr = new StreamReader(@"../../DataStorage/Account.txt"); //讀取帳號資料
            while (!sr.EndOfStream) //如果沒有到結數字元
            {
                String[] words = null; 
                ClientAccount account = new ClientAccount();
                string line = sr.ReadLine();

                words = _datamanagement.seperateData(line);
                account.Id = words[0];
                account.Account = words[1];
                account.Passward = words[2];
                account.Name = words[3];
                _accountList.Add(account);
            }
            sr.Close();

            /*if(!_datamanagement.doAccountDataManagement(str, _accountList)) //新帳號已有
            {
                Console.WriteLine("false");
            }
            */
            //Console.WriteLine(_accountList.Count);

           // Console.WriteLine(_accountList.Count);
        }

        public void run() //執行Socket
        {

            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, ChatSetting.port);

            Socket newsock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            newsock.Bind(ipep);
            newsock.Listen(10);

            while (true)
            {
                Socket socket = newsock.Accept();
                Console.WriteLine("接受一個新連線!");
                ChatSocket client = new ChatSocket(socket);
                try
                {
                    client.number = _clientList.Count();
                    _clientList.Add(client);
                    client.newListener(processMsgComeIn);
                }
                catch
                {
                }
                //                clientList.Remove(client);
            }
            //      newsock.Close();
        }

        public String processMsgComeIn(String msg, int clientSocketNumber) //接收資料
        {
            Console.WriteLine("收到訊息：" + msg);
            if(msg[0] == '0') //新申請帳號
            {
                if (!_datamanagement.doAccountDataManagement(msg, _accountList, '0'))
                {
                    broadCast("FALSE", clientSocketNumber);
                }
                else
                {
                    broadCast("OK", clientSocketNumber);
                }
            }
            else if(msg[1] == '1') //判斷帳號密碼是否存在
            {
                String[] words = null;
                int accountNumber = -2;
                words = _datamanagement.seperateData(msg);
                accountNumber = _datamanagement.compareData(words, _accountList, '1');
                if (accountNumber >= 0)
                {
                    findClient(clientSocketNumber, accountNumber);
                    broadCast("OK", clientSocketNumber);
                }

                broadCast("FALSE", clientSocketNumber);
            }

            else if(msg[1] == '2')
            {


            }

            return "OK";
        }

        private void findClient(int clientSocketNumber, int accountNumber)
        {
            for (int i = 0; i < _clientList.Count(); i++)
            {
                if (!_clientList[i].isDead)
                {
                    if (_clientList[i].number == clientSocketNumber)
                    {
                        _clientList[i].account = _accountList[accountNumber];
                    }
                }
            }
        }

        public void broadCast(String msg, int clientSocketNumber) //送出資料
        {
            Console.WriteLine("接收 " + msg );
            foreach (ChatSocket client in _clientList)
            {
                if (!client.isDead)
                {
                    if (client.number == clientSocketNumber)
                    {
                        Console.WriteLine("Send to " + client.remoteEndPoint.ToString() + ":" + msg);
                        client.send(msg);
                    }
                }
            }
        }
    }


}
