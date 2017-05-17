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
            _account.RemoveAt(id);
        }

        public bool changeAccountItem(int id, int cost, String name)
        {
            _account[id].Cost = cost;
            _account[id].ItemName = name;
            return true;
        }

        public AccountItem get(int i)
        {
            return _account[i];
        }

        public int Count()
        {
            return _account.Count;
        }

    }
}
