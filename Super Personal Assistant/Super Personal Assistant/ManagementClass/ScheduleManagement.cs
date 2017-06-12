using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Super_Personal_Assistant
{
    public class ScheduleManagement
    {
        private List<Activity> _activities = new List<Activity>();
        private int _nextId = 0;

        public ScheduleManagement()
        {
            _activities.Clear();
        }

        public void addNewActivity(Activity newActivity)
        {
            newActivity.Id = _nextId;
            _activities.Add(newActivity);
            _nextId++;
        }

        public void deleteActivity(int id)
        {
            Activity resultActivity = _activities.Find(searchActivity => searchActivity.Id.Equals(id));
            _activities.Remove(resultActivity);
        }

        public void changeActivity(int id, string title, string body)
        {
            Activity resultActivity = _activities.Find(searchActivity => searchActivity.Id.Equals(id));
            resultActivity.Title = title;
            resultActivity.Body = body;
        }

        public int Count()
        {
            return _activities.Count;
        }

        public List<Activity> checkHasActivity(DateTime today)
        {
            List<Activity> todayActivity = new List<Activity>();

            foreach(Activity activity in _activities)
            {       
                if (new DateTime(activity.Date.Year,activity.Date.Month,activity.Date.Day) == today)
                {
                    todayActivity.Add(activity);
                }
            }
            if (todayActivity.Count != 0)
                return todayActivity;

            return null ;
        }

        public Activity TimeOut(DateTime today)
        {
            foreach (Activity activity in _activities)
            {

                if (activity.Date == new DateTime(today.Year, today.Month, today.Day, today.Hour, today.Minute, 0) )
                {
                    return activity;
                }
            }

            return null;
        }

    }
}
