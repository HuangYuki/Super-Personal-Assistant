using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Super_Personal_Assistant
{

    public class ScheduleManagement
    {
        private List<Activity> _activity = new List<Activity>();

        public ScheduleManagement()
        {
            _activity.Clear();
        }

        public void addNewActivity(Activity newActivity)
        {
            _activity.Add(newActivity);
        }

        public void deleteActivity(int id)
        {

        }

        public void changeActivity()
        {

        }

        public int Count()
        {
            return _activity.Count;
        }


        public List<Activity> checkHasActivity(DateTime today)
        {
            List<Activity> todayActivity = new List<Activity>();

            foreach(Activity activity in _activity)
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
            foreach (Activity activity in _activity)
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
