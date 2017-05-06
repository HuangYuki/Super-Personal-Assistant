using Super_Personal_Assistant.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Super_Personal_Assistant
{
    class AccountItemManagement
    {
        private List<AccountItem> _account = new List<AccountItem>();

        public AccountItemManagement()
        {
            _account.Clear();
        }

        public void addNewAccountItem(AccountItem newActivity)
        {
            _account.Add(newActivity);
        }

        public void deleteAccountItem()
        {

        }

        public bool changeAccountItem(int id, int cost, String name)
        {
            int a= _account.FindIndex(x => x.Id == id);
            _account[a].Cost = cost;
            _account[a].ItemName = name;

            return true;
        }

        public int Count()
        {
            return _account.Count;
        }

    }
}
