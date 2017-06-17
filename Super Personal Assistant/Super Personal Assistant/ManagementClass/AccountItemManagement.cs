using Super_Personal_Assistant.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Super_Personal_Assistant
{
    public class AccountItemManagement
    {
        private List<AccountItem> _account = new List<AccountItem>();
        private int _nextId = 0;

        /// <summary>
        /// 初始化
        /// </summary>
        public AccountItemManagement()
        {
            _account.Clear();
        }

        /// <summary>
        /// 新增一筆記帳
        /// </summary>
        /// <param name="newActivity"></param>
        public void addNewAccountItem(AccountItem newActivity)
        {
            newActivity.Id = _nextId;
            _account.Add(newActivity);
            _nextId++;

            saveData();
        }

        /// <summary>
        /// 刪除一筆記帳
        /// </summary>
        /// <param name="id"></param>
        public void deleteAccountItem(int id)
        {
            AccountItem resultAccount = _account.Find(searchAccount => searchAccount.Id.Equals(id));
            _account.Remove(resultAccount);
        }

        /// <summary>
        /// 編輯一筆記帳
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cost"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool changeAccountItem(int id, int cost, String name)
        {
            AccountItem resultAccount = _account.Find(searchAccount => searchAccount.Id.Equals(id));
            resultAccount.ItemName = name;
            resultAccount.Cost = cost;
            return true;
        }

        /// <summary>
        /// 獲得記帳List總數
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            return _account.Count;
        }

        /// <summary>
        /// 獲取第N筆記帳資料
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public AccountItem getItem(int index)
        {
            return _account[index];
        }

        /// <summary>
        /// 獲得總金額
        /// </summary>
        /// <returns></returns>
        public int getMoneyTotal()
        {
            int total = 0;
            foreach (AccountItem ai in _account)
            {
                total += ai.Cost;
            }
            return total;
        }

        /// <summary>
        /// 獲得整個記帳的List
        /// </summary>
        /// <returns></returns>
        public List<AccountItem> getList()
        {
            return _account;
        }

        /// <summary>
        /// 將List中資料依格式儲存
        /// </summary>
        /// <returns></returns>
        private string saveData()
        {
            StreamWriter accountFileWriter = new StreamWriter("aaa_Account.txt", false);
            for (int index = 0; index < _account.Count; index++)
            {
                //程式代碼_帳戶_該筆資料ID_該筆資料日期_該筆收支描述_該筆資料收支
                string dataString = "";
                if (index == 0) dataString = "51";
                else dataString = "5";

                dataString += "_" + "aaa"
                            + "_" + _account[index].Id.ToString()
                            + "_" + _account[index].Date.ToString("yyyy/MM/dd")
                            + "_" + _account[index].ItemName
                            + "_" + _account[index].Cost;

                accountFileWriter.WriteLine(dataString);
            }
            accountFileWriter.Close();

            return "OK";
        }

        /// <summary>
        /// 將接收到的資料依格式解析並載入
        /// </summary>
        /// <returns></returns>
        public string recieveData()
        {
            if (File.Exists("aaa_Account.txt"))
            {
                StreamReader accountFileReader = new StreamReader("aaa_Account.txt");
                _account.Clear();
                while (true)
                {
                    string dataString = accountFileReader.ReadLine();
                    if (dataString == null) break;

                    //程式代碼_帳戶_該筆資料ID_該筆資料日期_該筆收支描述_該筆資料收支
                    string[] splitData = dataString.Split('_');
                    AccountItem newAccount = new AccountItem();
                    newAccount.Id = Convert.ToInt32(splitData[2]);
                    DateTime resultDate = Tool.StringToDate(splitData[3]);
                    newAccount.Date = new DateTime(resultDate.Year, resultDate.Month, resultDate.Day);
                    newAccount.ItemName = splitData[4];
                    newAccount.Cost = Convert.ToInt32(splitData[5]);

                    _account.Add(newAccount);
                }
                _nextId = _account[_account.Count - 1].Id + 1;
                accountFileReader.Close();
            }
            return "OK";
        }
    }
}
