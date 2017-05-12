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
                Assert.AreEqual(t[i].Id, aim.get(i).Id);
                Assert.AreEqual(t[i].Cost, aim.get(i).Cost);
                Assert.AreEqual(t[i].ItemName, aim.get(i).ItemName);
                Assert.AreEqual(t[i].Date, aim.get(i).Date);
            }

        }
    }
}
