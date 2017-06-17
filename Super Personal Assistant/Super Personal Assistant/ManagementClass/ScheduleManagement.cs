using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Super_Personal_Assistant
{
    public class ScheduleManagement
    {
        private List<Activity> _activities = new List<Activity>();
        private int _nextId = 0;

        /// <summary>
        /// 初始化
        /// </summary>
        public ScheduleManagement()
        {
            _activities.Clear();
        }

        /// <summary>
        /// 新增一筆行程
        /// </summary>
        /// <param name="newActivity"></param>
        public void addNewActivity(Activity newActivity)
        {
            newActivity.Id = _nextId;
            _activities.Add(newActivity);
            _nextId++;

            saveData();
        }

        /// <summary>
        /// 刪除一筆行程
        /// </summary>
        /// <param name="id"></param>
        public void deleteActivity(int id)
        {
            Activity resultActivity = _activities.Find(searchActivity => searchActivity.Id.Equals(id));
            _activities.Remove(resultActivity);
        }

        /// <summary>
        /// 編輯一筆行程
        /// </summary>
        /// <param name="id"></param>
        /// <param name="title"></param>
        /// <param name="body"></param>
        public void changeActivity(int id, string title, string body)
        {
            Activity resultActivity = _activities.Find(searchActivity => searchActivity.Id.Equals(id));
            resultActivity.Title = title;
            resultActivity.Body = body;
        }

        /// <summary>
        /// 獲得行程List總數
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            return _activities.Count;
        }

        /// <summary>
        /// 檢查當日是否有行程，若有行程就回傳，無則回傳null
        /// </summary>
        /// <param name="today"></param>
        /// <returns></returns>
        public List<Activity> checkHasActivity(DateTime today)
        {
            List<Activity> todayActivity = new List<Activity>();

            foreach (Activity activity in _activities)
            {
                if (new DateTime(activity.Date.Year, activity.Date.Month, activity.Date.Day) == today)
                {
                    todayActivity.Add(activity);
                }
            }
            if (todayActivity.Count != 0)
                return todayActivity;

            return null;
        }

        /// <summary>
        /// 倒數計時時間到
        /// </summary>
        /// <param name="today"></param>
        /// <returns></returns>
        public Activity TimeOut(DateTime today)
        {
            foreach (Activity activity in _activities)
            {

                if (activity.Date == new DateTime(today.Year, today.Month, today.Day, today.Hour, today.Minute, 0))
                {
                    return activity;
                }
            }

            return null;
        }

        /// <summary>
        /// 將List中資料依格式儲存
        /// </summary>
        /// <returns></returns>
        private string saveData()
        {
            //ClientSocket dataSender;

            StreamWriter scheduleFileWriter = new StreamWriter("aaa_Schedule.txt", false);
            for (int index = 0; index < _activities.Count; index++)
            {
                //程式代碼_帳戶_該筆行程ID_該筆行程日期_該筆行程時間_該筆行程標題_該筆行程描述
                string dataString = "";
                if (index == 0) dataString = "61";
                else dataString = "6";

                dataString += "_" + "aaa"
                            + "_" + _activities[index].Id.ToString()
                            + "_" + _activities[index].Date.ToString("yyyy/MM/dd_HH:mm")
                            + "_" + _activities[index].Title
                            + "_" + _activities[index].Body;

                scheduleFileWriter.WriteLine(dataString);

            }
            scheduleFileWriter.Close();

            return "OK";
        }

        /// <summary>
        /// 將接收到的資料依格式解析並載入
        /// </summary>
        /// <returns></returns>
        public string recieveData()
        {
            if (File.Exists("aaa_Schedule.txt"))
            {
                StreamReader scheduleFileReader = new StreamReader("aaa_Schedule.txt");
                _activities.Clear();
                while (true)
                {
                    string dataString = scheduleFileReader.ReadLine();
                    if (dataString == null) break;

                    //程式代碼_帳戶_該筆行程ID_該筆行程日期_該筆行程時間_該筆行程標題_該筆行程描述
                    string[] splitData = dataString.Split('_');
                    Activity newTask = new Activity();
                    newTask.Id = Convert.ToInt32(splitData[2]);
                    DateTime resultDate = Tool.StringToDate(splitData[3]);
                    DateTime resultTime = Tool.StringToTime(splitData[4]);
                    newTask.Date = new DateTime(resultDate.Year, resultDate.Month, resultDate.Day, resultTime.Hour, resultTime.Minute, resultTime.Second);
                    newTask.Title = splitData[5];
                    newTask.Body = splitData[6];

                    _activities.Add(newTask);
                }
                _nextId = _activities[_activities.Count - 1].Id + 1;
                scheduleFileReader.Close();
            }
            return "OK";
        }
    }
}
