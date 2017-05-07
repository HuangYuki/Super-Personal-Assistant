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
        List<ChatSocket> clientList = new List<ChatSocket>();
        

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

           // Console.WriteLine(_accountList.Count);
        }

        public void run()
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
                    clientList.Add(client);
                    client.newListener(processMsgComeIn);
                }
                catch
                {
                }
                //                clientList.Remove(client);
            }
            //      newsock.Close();
        }

        public String processMsgComeIn(String msg) //接收資料
        {
            Console.WriteLine("收到訊息：" + msg);
            if (!_datamanagement.doDataManagement(msg,  _accountList))
            {
                Console.WriteLine("false");
                Console.WriteLine(_accountList.Count);
                broadCast("FALSE");
            }
            else
            {
                broadCast("OK");
                Console.WriteLine(_accountList.Count);
            }

            return "OK";
        }

        public void broadCast(String msg) //送出資料
        {
            Console.WriteLine("接收 " + msg );
            foreach (ChatSocket client in clientList)
            {
                if (!client.isDead)
                {
                    Console.WriteLine("Send to " + client.remoteEndPoint.ToString() + ":" + msg);
                    client.send(msg);
                }
            }
        }
    }


}
