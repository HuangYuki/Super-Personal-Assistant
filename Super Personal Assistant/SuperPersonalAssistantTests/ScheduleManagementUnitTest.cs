using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Super_Personal_Assistant;
using System.Collections.Generic;
using System.Linq;

namespace SuperPersonalAssistantTests
{
    [TestClass]
    public class ScheduleManagementUnitTest
    {
        [TestMethod]
        public void TestCheckHasActivity()
        {
            
            ScheduleManagement s = new ScheduleManagement();
            s.addNewActivity(new Activity(new DateTime(10, 1, 1),"","",0));
            List<Activity> a = s.checkHasActivity(new DateTime(1, 1, 1));
            //沒找到
            Assert.IsNull(a);            
            //Assert.IsTrue(test.SequenceEqual(test2));
            //CollectionAssert.AreEqual(test2,test);
        }
    }
}
