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
        List<ChatSocket> _clientList = new List<ChatSocket>();
        

        public ConnectionManagement()
        {
            InitializeAccount();
        }

        public void InitializeAccount() //初始化所有帳號
        {
            DataManagement _datamanagement = new DataManagement();

            if (!File.Exists(@"../../DataStorage/Account/Account.txt"))
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
            DataManagement _datamanagement = new DataManagement();

            Console.WriteLine("收到訊息：" + msg);
            if(msg[0] == '0') //新申請帳號
            {
                if (!_datamanagement.doAccountDataManagement(msg, _accountList, '0'))
                {
                    broadCast("FALSE", clientSocketNumber);
                }
                else
                {
                    _datamanagement.createAllFile(_accountList);
                    broadCast("OK", clientSocketNumber);
                    //做資料夾建置
                }
            }
            else if(msg[0] == '1') //判斷帳號密碼是否存在words[1]帳號
            {
                String[] words = null;
                int accountNumber = -2;
                words = _datamanagement.seperateData(msg);
                accountNumber = _datamanagement.compareData(words, _accountList, '1');

                if (accountNumber >= 0)
                {
                    findClient(clientSocketNumber, accountNumber);
                    _datamanagement.InitiallizeFriend(words[1], _clientList[clientSocketNumber].clientFreindAccount, _accountList); //初始化朋友到SERVER的CLIENTSOCKET
                    broadCast("1_" + _accountList[accountNumber].Name, clientSocketNumber);

                    List<string> tmpFriend = new List<string>();
                    FriendManagement friendManagement = new FriendManagement();
                    tmpFriend = friendManagement.InitiallizeFreind(words[1]);
                    for (int i = 0; i < tmpFriend.Count; i++)
                    {
                        broadCast("9_" + tmpFriend[i], clientSocketNumber);
                    }
                    broadCast("9_OK", clientSocketNumber);
                    //傳SERVER的好友給 CLIENT


                }
                else
                {
                    broadCast("1_FALSE", clientSocketNumber);
                }
            }

            else if(msg[0] == '2')  //初始化好友訊息 2_帳號_好友帳號
            {
                List<string> tmpMessage = new List<string>();
                MessageManagement messageManagement = new MessageManagement();
                tmpMessage = messageManagement.InitiallizeFreindMessage(msg);

                for (int i = 0; i < tmpMessage.Count; i++)
                {
                    broadCast("2_" + tmpMessage[i], clientSocketNumber);
                }
                broadCast("2_OK", clientSocketNumber);

            }

            else if (msg[0] == '3') //新增好友 3_好友帳號
            {
                String[] words = null;
                int accountfriendNumber = -2;
                words = _datamanagement.seperateData(msg);
                accountfriendNumber = _datamanagement.compareData(words, _accountList, '3'); //判斷好友存不存在
                int index = 0;

                if (accountfriendNumber >= 0)//判斷存不存在
                {
                    int friendClientNumber;
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
                        broadCast("3_OK", clientSocketNumber); //找到

                        for (int i = 0; i < _clientList.Count(); i++)
                        {
                            if (!_clientList[i].isDead)
                            {
                                if (_clientList[i].account.Account == _accountList[accountfriendNumber].Account) //判斷好友在不再線上
                                {

                                    friendClientNumber = i; //朋友號碼
                                    index = 0;
                                    for (int j = 0; j < _clientList[i].clientFreindAccount.Count; j++)
                                    {
                                        if (_clientList[i].clientFreindAccount[j].Account == _clientList[clientSocketNumber].account.Account) //判斷對方有沒有好友
                                        {
                                            index++; //有的話
                                            Console.WriteLine("index" + index);
                                            broadCast("31_" + _clientList[i].clientFreindAccount[j].Account + "_"+  _clientList[i].clientFreindAccount[j].Name, clientSocketNumber); //傳成功(對方已有好友)
                                            //broadCast("3_OK", clientSocketNumber); //找到
                                            break;
                                        }
                                    }
                                    if (index == 0)
                                    {
                                        broadCast("3_" + _clientList[clientSocketNumber].account.Account, friendClientNumber); //傳給那個朋友
                                    }
                                    _datamanagement.createMessageFile(_clientList[clientSocketNumber].account.Account, _accountList[accountfriendNumber].Account);
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

            else if (msg[0] == '4') //4_帳號_對方帳號_內容
            {
                String[] words = null;
                words = _datamanagement.seperateData(msg);
                int index = 0;
                int index1 = 0;

                for (int i = 0; i < _clientList.Count(); i++)
                {
                    if (!_clientList[i].isDead)
                    {
                        if (_clientList[i].account.Account == words[2]) //判斷對方在不再線上 對方為 i
                        {
                            index1++;
                            index = 0;
                            for (int j = 0; j < _clientList[i].clientFreindAccount.Count; j++)
                            {
                                if(_clientList[i].clientFreindAccount[j].Account == _clientList[clientSocketNumber].account.Account) //判斷對方有沒有好友
                                {
                                    index++; //有的話
                                    broadCast("4_" + _clientList[clientSocketNumber].account.Account + "_" + words[3], i); //傳給對方
                                    broadCast("4_OK", clientSocketNumber); //傳成功

                                    MessageManagement saveTmpMessage = new MessageManagement();

                                    saveTmpMessage.saveMessage(words);
                                }
                            }
                            if(index == 0)
                            {
                                broadCast("4_FALSE", clientSocketNumber); //沒有好友
                            }
                            index = 0;
                        }
                    }
                }
                if(index1 == 0)
                {
                    broadCast("4_NOTFOUND", clientSocketNumber); //找不到人沒上線
                }
                index1 = 0;
                //如果對方不再線上回傳 (4_NOTFOUND)
                //判斷是不是對方的朋友(不是回傳4_FALSE)
                //是回傳4_OK傳給對方
            }

            else if(msg[0] == '5')
            {
                AccountItemManagement accountItem = new AccountItemManagement();

                accountItem.saveAccountItem(msg);
            }

            else if(msg[0] == '6')
            {
                ScheduleManagement schedule = new ScheduleManagement();

                schedule.saveScheduleItem(msg);
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
