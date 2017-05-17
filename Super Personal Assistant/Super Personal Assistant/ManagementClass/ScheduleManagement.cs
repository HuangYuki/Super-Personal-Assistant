using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Super_Personal_Assistant
{

    public class ScheduleManagement
    {
        private List<Activity> _activities = new List<Activity>();

        public ScheduleManagement()
        {
            _activities.Clear();
        }

        public void addNewActivity(Activity newActivity)
        {
            _activities.Add(newActivity);
        }

        public void deleteActivity(int id)
        {
            _activities.RemoveAt(id);
        }

        public void changeActivity(int id, string title, string body)
        {
            _activities[id].Title = title;
            _activities[id].Body = body;
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
