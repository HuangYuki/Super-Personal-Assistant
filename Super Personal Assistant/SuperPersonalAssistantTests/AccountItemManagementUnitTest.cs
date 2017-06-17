using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Super_Personal_Assistant;
using System.Collections.Generic;
using Super_Personal_Assistant.Class;

namespace SuperPersonalAssistantTests
{
    /// <summary>
    /// AccountItemManagementUnitTest 的摘要說明
    /// </summary>
    [TestClass]
    public class AccountItemManagementUnitTest
    {
        //測試 function ChangeAccountItem() 找到
        [TestMethod]
        public void TestChangeAccountItem()
        {
            AccountItemManagement aim = new AccountItemManagement();
            aim.addNewAccountItem(new AccountItem(0,100,"test",new DateTime(10,10,10)));
            aim.changeAccountItem(0, 200, "test2");

            List<AccountItem> t = new List<AccountItem>
            {
                new AccountItem(0, 200, "test2", new DateTime(10, 10, 10))
            };


            Assert.AreEqual(t.Count, aim.Count());
            for(int i = 0; i < t.Count; i++)
            {
                Assert.AreEqual(t[i].Id, aim.getItem(i).Id);
                Assert.AreEqual(t[i].Cost, aim.getItem(i).Cost);
                Assert.AreEqual(t[i].ItemName, aim.getItem(i).ItemName);
                Assert.AreEqual(t[i].Date, aim.getItem(i).Date);
            }

        }

        //測試 function DeleteAccountItem() 找到
        [TestMethod]
        public void TestDeleteAccountItem()
        {
            AccountItemManagement aim = new AccountItemManagement();
            aim.addNewAccountItem(new AccountItem(0, 100, "test", new DateTime(10, 10, 10)));
            aim.addNewAccountItem(new AccountItem(0, 200, "test2222", new DateTime(10, 10, 10)));
            aim.deleteAccountItem(0);

            List<AccountItem> t = new List<AccountItem>
            {
                new AccountItem(0, 200, "test2222", new DateTime(10, 10, 10))
            };

            Assert.AreEqual(t.Count, aim.Count());
            for (int i = 0; i < t.Count; i++)
            {
                Assert.AreEqual(t[i].Cost, aim.getItem(i).Cost);
                Assert.AreEqual(t[i].ItemName, aim.getItem(i).ItemName);
                Assert.AreEqual(t[i].Date, aim.getItem(i).Date);
            }

        }

        //測試 function getTotal() 找到
        [TestMethod]
        public void TestGetTotal()
        {
            AccountItemManagement aim = new AccountItemManagement();
            aim.addNewAccountItem(new AccountItem(0, 100, "test", new DateTime(10, 10, 10)));
            aim.addNewAccountItem(new AccountItem(0, 200, "test2222", new DateTime(10, 10, 10)));
            aim.addNewAccountItem(new AccountItem(0, 222, "test2222", new DateTime(10, 10, 10)));

            Assert.AreEqual(aim.getMoneyTotal(), 522);
        }
    }

}
