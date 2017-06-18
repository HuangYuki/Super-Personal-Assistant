using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Super_Personal_Assistant;
using System.Collections.Generic;

namespace SuperPersonalAssistantTests
{
    [TestClass]
    public class ScheduleManagementUnitTest
    {
        //測試 function CheckHasActivity() 沒找到
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

        //測試 function CheckHasActivity() 有找到
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

        //測試 function TimeOut() 找到
        [TestMethod]
        public void TestTimeOutSuccess()
        {
            ScheduleManagement s = new ScheduleManagement();
            s.addNewActivity(new Activity(new DateTime(10, 1, 1), "1", "1", 10));
            Activity test = s.TimeOut(new DateTime(10, 1, 1));

            Assert.AreEqual(test.Date, new DateTime(10, 1, 1));
            Assert.AreEqual(test.Title, "1");
            Assert.AreEqual(test.Body, "1");
            Assert.AreEqual(test.Id, 0);    
        }

        //測試 function TimeOut() 沒找到
        [TestMethod]
        public void TestTimeOutFail()
        {
            ScheduleManagement s = new ScheduleManagement();
            s.addNewActivity(new Activity(new DateTime(12, 1, 1), "1", "1", 10));
            Activity test = s.TimeOut(new DateTime(10, 1, 1));
            Assert.IsNull(test);
        }

        //測試 function deleteActivity()
        [TestMethod]
        public void TestDeleteActivity()
        {
            ScheduleManagement s = new ScheduleManagement();
            ScheduleManagement test = new ScheduleManagement();         
            s.addNewActivity(new Activity(new DateTime(12, 1, 10), "1.", "1", 0));
            s.addNewActivity(new Activity(new DateTime(12, 1, 11), "2.", "11", 0));
            s.addNewActivity(new Activity(new DateTime(12, 1, 12), "3.", "111", 0));
            s.deleteActivity(1);

            test.addNewActivity(new Activity(new DateTime(12, 1, 10), "1.", "1", 0));
            test.addNewActivity(new Activity(new DateTime(12, 1, 12), "3.", "111", 0));


            for (int i = 0; i < s.Count(); i++)
            {
                Assert.AreEqual(s.getItem(i).Date, test.getItem(i).Date);
                Assert.AreEqual(s.getItem(i).Title, test.getItem(i).Title);
                Assert.AreEqual(s.getItem(i).Body, test.getItem(i).Body);
            }

        }

        //測試 function changeActivity()
        [TestMethod]
        public void TesChangeActivity()
        {
            ScheduleManagement s = new ScheduleManagement();
            ScheduleManagement test = new ScheduleManagement();
            s.addNewActivity(new Activity(new DateTime(12, 1, 10), "1.", "1", 0));
            s.addNewActivity(new Activity(new DateTime(12, 1, 11), "2.", "11", 0));
            s.addNewActivity(new Activity(new DateTime(12, 1, 12), "3.", "111", 0));
            s.changeActivity(1,"test1","testing");

            test.addNewActivity(new Activity(new DateTime(12, 1, 10), "1.", "1", 0));
            test.addNewActivity(new Activity(new DateTime(12, 1, 11), "test1", "testing", 0));
            test.addNewActivity(new Activity(new DateTime(12, 1, 12), "3.", "111", 0));


            for (int i = 0; i < s.Count(); i++)
            {
                Assert.AreEqual(s.getItem(i).Date, test.getItem(i).Date);
                Assert.AreEqual(s.getItem(i).Title, test.getItem(i).Title);
                Assert.AreEqual(s.getItem(i).Body, test.getItem(i).Body);
            }
        }
    }
}
