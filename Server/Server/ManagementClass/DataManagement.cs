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
            char space = ' ';
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
                newData = newData + " " + words[i];
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
            if (_accountList.Where(item => item.Account == words[1] && item.Passward == words[2]).Count() > 0)
            {
                for (int i = 0; i < _accountList.Count; i++)
                {
                    if (words[1] == _accountList[i].Account && words[2] == _accountList[i].Passward)
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
            StreamWriter sw = new StreamWriter(@"../../DataStorage/Account.txt", true);
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

    }
}
