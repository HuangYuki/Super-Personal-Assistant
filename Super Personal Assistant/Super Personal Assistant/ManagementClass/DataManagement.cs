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
        ClientAccount clientAccount = new ClientAccount();

        public bool doDataManagement(String data, List<ClientAccount> _accountList)
        {
            int dataTypeId = -1;
            string[] words = null; //分離的字

            dataTypeId = getDataType(data);
            words = seperateData(dataTypeId, data);
            if(dataTypeId == 0)
            {
                if (SaveClientAccountData(dataTypeId, words, _accountList) == false)
                {
                    return false;
                }
            }

            return true;
        }

        public int getDataType(String data) //資料型態
        {
            int typeId = 0;

            typeId = data[0] - '0';

            return typeId;
        }

        public String[] seperateData(int typeId, string data) //分離資料
        {
            char space = ' ';
            string[] words = null;

            words = data.Split(space);

            return words;
        }

        public String mergeData(string[] words, int accountNumber) //重組資料
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

        public bool compareData(int typeId, String[] words, List<ClientAccount> _accountList) //比較資料
        {
            if(typeId == 0)
            {
                for(int i = 0; i < _accountList.Count; i++)
                {
                    if(words[1] == _accountList[i].Account)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool SaveClientAccountData(int typeId, string[] words, List<ClientAccount> _accountList) //存檔
        {
            string newData = null;
            StreamWriter sw = new StreamWriter(@"../../DataStorage/Account.txt", true);

            if (compareData(typeId, words, _accountList) == false)
            {
                sw.Close();
                return false;
            }

            newData = mergeData(words, _accountList.Count());
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
