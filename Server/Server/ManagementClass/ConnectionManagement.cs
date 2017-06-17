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
            if(!File.Exists(@"../../DataStorage/Account/Account.txt"))
            {
                FileStream fileStream = new FileStream(@"../../DataStorage/Account/Account.txt", FileMode.Create);
                fileStream.Close();
            }
            StreamReader sr = new StreamReader(@"../../DataStorage/Account/Account.txt"); //讀取帳號資料

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

        public String processMsgComeIn(String msg, int clientSocketNumber) //接收資料 clientSocketNumber = 我的socket編號
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
            else if(msg[0] == '1') //判斷帳號密碼是否存在
            {
                String[] words = null;
                int accountNumber = -2;
                words = _datamanagement.seperateData(msg);
                accountNumber = _datamanagement.compareData(words, _accountList, '1');

                if (accountNumber >= 0)
                {
                    findClient(clientSocketNumber, accountNumber);
                    broadCast("1_" + _accountList[accountNumber].Name, clientSocketNumber);
                }
                else
                {
                    broadCast("1_FALSE", clientSocketNumber);
                }
            }

            else if(msg[0] == '2')      
            {


            }

            else if (msg[0] == '3') //新增好友
            {
                String[] words = null;
                int accountfriendNumber = -2;
                words = _datamanagement.seperateData(msg);
                accountfriendNumber = _datamanagement.compareData(words, _accountList, '3'); //判斷好友存不存在
                int index = 0;

                if (accountfriendNumber >= 0)//判斷存不存在
                {
                    broadCast("3_OK", clientSocketNumber); //找到
                    int friendClientNumber;

                    for (int i = 0; i < _clientList.Count(); i++)
                    {
                        if (!_clientList[i].isDead)
                        {
                            if (_clientList[i].account.Account == _accountList[accountfriendNumber].Account) //判斷好友在不再線上
                            {
                                int indexExist = 0;

                                for (int k = 0; k < _clientList[clientSocketNumber].clientFreindAccount.Count; k++)
                                {
                                    if (_clientList[clientSocketNumber].clientFreindAccount[k].Account == _accountList[accountfriendNumber].Account) //判斷有沒有好友
                                    {
                                        indexExist++;
                                        Console.WriteLine("indexExist" + indexExist);
                                        broadCast("3_EXIST", clientSocketNumber); //已有好友
                                        break;
                                    }
                                }
                                if (indexExist == 0)
                                {
                                    friendClientNumber = i; //朋友號碼
                                    index = 0;
                                    for (int j = 0; j < _clientList[i].clientFreindAccount.Count; j++)
                                    {
                                        if (_clientList[i].clientFreindAccount[j].Account == _clientList[clientSocketNumber].account.Account) //判斷對方有沒有好友
                                        {
                                            index++; //有的話
                                            Console.WriteLine("index" + index);
                                            broadCast("3_OK", clientSocketNumber); //傳成功
                                            break;
                                        }
                                    }
                                    if (index == 0)
                                    {
                                        broadCast("3_" + _clientList[clientSocketNumber].account.Account, friendClientNumber); //傳給那個朋友
                                    }

                                    _clientList[clientSocketNumber].clientFreindAccount.Add(_accountList[accountfriendNumber]); //加到好友
                                    _datamanagement.saveFriend(_clientList[clientSocketNumber].account, accountfriendNumber, _clientList[clientSocketNumber].clientFreindAccount);
                                }
                            }
                        }
                    }
                }
                else
                {
                    broadCast("3_FALSE", clientSocketNumber);
                }
            }

            else if (msg[0] == '4') //4_對方帳號_內容
            {
                String[] words = null;
                words = _datamanagement.seperateData(msg);
                int index = 0;
                int index1 = 0;

                for (int i = 0; i < _clientList.Count(); i++)
                {
                    if (!_clientList[i].isDead)
                    {
                        if (_clientList[i].account.Account == words[1]) //判斷對方在不再線上 對方為 i
                        {
                            index1++;
                            index = 0;
                            for (int j = 0; j < _clientList[i].clientFreindAccount.Count; j++)
                            {
                                if(_clientList[i].clientFreindAccount[j].Account == _clientList[clientSocketNumber].account.Account) //判斷對方有沒有好友
                                {
                                    index++; //有的話
                                    broadCast("4_" + _clientList[clientSocketNumber].account.Account + words[2], i); //傳給對方
                                    broadCast("4_OK", clientSocketNumber); //傳成功
                                }
                            }
                            if(index == 0)
                            {
                                broadCast("4_False", clientSocketNumber); //沒有好友
                            }
                        }
                    }
                }
                if(index1 == 0)
                {
                    broadCast("4_NOTFOUND", clientSocketNumber); //找不到人沒上線
                }
                //如果對方不再線上回傳 (4_NOTFOUND)
                //判斷是不是對方的朋友(不是回傳4_FALSE)
                //是回傳4_OK傳給對方
            }

            else if(msg[0] == '5')
            {

            }

            else if(msg[0] == '6')
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
            Console.WriteLine("送出" + msg );
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
