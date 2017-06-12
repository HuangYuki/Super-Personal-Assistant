using Super_Personal_Assistant.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Super_Personal_Assistant
{
    public class AccountItemManagement
    {
        private List<AccountItem> _account = new List<AccountItem>();
        private int _nextId = 0;

        public AccountItemManagement()
        {
            _account.Clear();
        }

        public void addNewAccountItem(AccountItem newActivity)
        {
            newActivity.Id = _nextId;
            _account.Add(newActivity);
            _nextId++;
        }

        public void deleteAccountItem(int id)
        {
            AccountItem resultAccount = _account.Find(searchAccount => searchAccount.Id.Equals(id));
            _account.Remove(resultAccount);
        }

        public bool changeAccountItem(int id, int cost, String name)
        {
            AccountItem resultAccount = _account.Find(searchAccount => searchAccount.Id.Equals(id));
            resultAccount.ItemName = name;
            resultAccount.Cost = cost;
            return true;
        }

        public int Count()
        {
            return _account.Count;
        }

        public AccountItem get(int index)
        {
            return _account[index];
        }

        public int getTotal()
        {
            int total = 0;
            foreach(AccountItem ai in _account)
            {
                total += ai.Cost;
            }
            return total;
        }

        public List<AccountItem> GetAccountList()
        {
            return _account;
        }
    }
}
