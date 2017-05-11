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
        public void TestCheckHasActivityIsNull()
        {
            
            ScheduleManagement s = new ScheduleManagement();
            s.addNewActivity(new Activity(new DateTime(10, 1, 1),"","",0));
            s.addNewActivity(new Activity(new DateTime(10, 1, 1), "1", "1", 1));
            List<Activity> a1 = s.checkHasActivity(new DateTime(1, 1, 1));
            //沒找到
            Assert.IsNull(a1);       
        }


        [TestMethod]
        public void TestCheckHasActivityNotNull()
        {

            ScheduleManagement s = new ScheduleManagement();
            s.addNewActivity(new Activity(new DateTime(10, 1, 1), "", "", 0));
            s.addNewActivity(new Activity(new DateTime(10, 1, 1), "1", "1", 1));

            List<Activity> a2 = s.checkHasActivity(new DateTime(10, 1, 1));
            List<Activity> test1 = new List<Activity>() {
                new Activity(new DateTime(10, 1, 1), "", "", 0),
                new Activity(new DateTime(10, 1, 1), "1", "1",1)};

            Assert.AreEqual(test1.Count, a2.Count);

            for (int i = 0; i < a2.Count; i++)
            {
                Assert.AreEqual(test1[i].Date, a2[i].Date);
                Assert.AreEqual(test1[i].Title, a2[i].Title);
                Assert.AreEqual(test1[i].Body, a2[i].Body);
                Assert.AreEqual(test1[i].Id, a2[i].Id);
            }
        }

        [TestMethod]
        public void TestTimeOutSuccess()
        {
            ScheduleManagement s = new ScheduleManagement();
            s.addNewActivity(new Activity(new DateTime(10, 1, 1), "1", "1", 10));
            Activity test = s.TimeOut(new DateTime(10, 1, 1));

            Assert.AreEqual(test.Date, new DateTime(10, 1, 1));
            Assert.AreEqual(test.Title, "1");
            Assert.AreEqual(test.Body, "1");
            Assert.AreEqual(test.Id, 10);    
        }

        [TestMethod]
        public void TestTimeOutFail()
        {
            ScheduleManagement s = new ScheduleManagement();
            s.addNewActivity(new Activity(new DateTime(12, 1, 1), "1", "1", 10));
            Activity test = s.TimeOut(new DateTime(10, 1, 1));
            Assert.IsNull(test);
        }
    }
}
