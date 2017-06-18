using Server.Class;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.ManagementClass
{
    class DataManagement
    {

        public bool doAccountDataManagement(String data, List<ClientAccount> _accountList, char dataType)
        {
            string[] words = null; //分離的字

            words = seperateData(data);
            if(dataType == '0')
            {
                if (SaveClientAccountData(words, _accountList, dataType) == false)
                {
                    return false;
                }
            }

            return true;
        }

        public String[] seperateData(string data) //分離資料
        {
            char space = '_';
            string[] words = null;

            words = data.Split(space);

            return words;
        }

        public String mergeData(string[] words, int accountNumber, ClientAccount clientAccount) //重組資料
        {
            string newData = null;

            for (int j = 0; j < 6 - accountNumber.ToString().Length; j++)
            {
                newData = newData + "0";
            }
            newData = newData + (accountNumber + 1).ToString();
            clientAccount.Id = newData;

            for (int i = 1; i < words.Length; i++)
            {
                newData = newData + "_" + words[i];
            }

            return newData;
        }

        public int compareData(String[] words, List<ClientAccount> _accountList, char dataType) //比較資料
        {
            if(dataType == '0')
            {
                if (_accountList.Where(item => item.Account == words[1]).Count() > 0)
                {

                    return -1; //-1為失敗
                }
            }
            else if (dataType == '1' && _accountList.Where(item => item.Account == words[1] && item.Passward == words[2]).Count() > 0)
            {
                for (int i = 0; i < _accountList.Count; i++)
                {
                    if (words[1] == _accountList[i].Account && words[2] == _accountList[i].Passward)
                    {
                        return i;
                    }
                }
            }

            else if (dataType == '3' && _accountList.Where(item => item.Account == words[1]).Count() > 0)
            {
                for (int i = 0; i < _accountList.Count; i++)
                {
                    if (words[1] == _accountList[i].Account)
                    {
                        return i;
                    }
                }
            }

            return -2; //-2為成功
        }

        public bool SaveClientAccountData(string[] words, List<ClientAccount> _accountList, char dataType) //存檔帳號
        {
            string newData = null;
            StreamWriter sw = new StreamWriter(@"../../DataStorage/Account/Account.txt",true);
            ClientAccount clientAccount = new ClientAccount();

            if (compareData(words, _accountList, dataType) == -1)
            {
                sw.Close();
                return false;
            }

            newData = mergeData(words, _accountList.Count(), clientAccount);
            clientAccount.Account = words[1];
            clientAccount.Passward = words[2];
            clientAccount.Name = words[3];
            _accountList.Add(clientAccount);
            sw.WriteLine(newData);
            sw.Close();

            return true;
        }
        
        public void saveFriend(ClientAccount myAccount, int friendAccountNumber, List<ClientAccount> _friendAcountList)
        {
            string path = myAccount.Account + "Friend"; 
            StreamWriter sw = new StreamWriter(@"../../DataStorage/Friend/" + path + ".txt");

            for(int i = 0; i < _friendAcountList.Count; i++)
            {
                sw.WriteLine(_friendAcountList[i].Account + "_" + _friendAcountList[i].Name);
            }
            sw.Close();
        }

        public void createAllFile(List<ClientAccount> _accountList)
        {
            string path = _accountList[_accountList.Count - 1].Account + "Friend";
            FileStream fileStream = new FileStream(@"../../DataStorage/Friend/" + path + ".txt", FileMode.Create);
            fileStream.Close();

            path = _accountList[_accountList.Count - 1].Account + "AccountItem";
            FileStream fileStream1 = new FileStream(@"../../DataStorage/AccountItem/" + path + ".txt", FileMode.Create);
            fileStream1.Close();

            path = _accountList[_accountList.Count - 1].Account + "Schedule";
            FileStream fileStream2 = new FileStream(@"../../DataStorage/Schedule/" + path + ".txt", FileMode.Create);
            fileStream2.Close();

            string dirPath = @"../../DataStorage/Message/" + _accountList[_accountList.Count - 1].Account + "Message";
            Directory.CreateDirectory(dirPath);
        }

        public void createMessageFile(string myAccount, string friendAccount)
        {
            string path = myAccount + "Message/" + myAccount + friendAccount;

            if (!File.Exists(@"../../DataStorage/Message/" + path + ".txt"))
            {
                FileStream fileStream = new FileStream(@"../../DataStorage/Message/" + path + ".txt", FileMode.Create);
                fileStream.Close();
            }

            string path2 = friendAccount + "Message/" + friendAccount + myAccount;

            if (!File.Exists(@"../../DataStorage/Message/" + path2 + ".txt"))
            {
                FileStream fileStream = new FileStream(@"../../DataStorage/Message/" + path2 + ".txt", FileMode.Create);
                fileStream.Close();
            }
        }

        public void InitiallizeFriend(string account, List<ClientAccount> _clientFriendList, List<ClientAccount> _accountList)
        {
            string path = account + "Friend";
            StreamReader sr = new StreamReader(@"../../DataStorage/Friend/" + path + ".txt");
            while (!sr.EndOfStream) //如果沒有到結數字元
            {
                String[] words = null;
                string line = sr.ReadLine();
                words = seperateData(line);

                for (int i=0;i < _accountList.Count; i++)
                {
                    if(_accountList[i].Account == words[0])
                    {
                        _clientFriendList.Add(_accountList[i]);
                        break;
                    }
                }
            }
            sr.Close();
        }

    }
}
