using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Super_Personal_Assistant
{

    public class Schedule
    {
        private List<Activity> _activity = new List<Activity>();

        public Schedule()
        {
            _activity.Clear();
        }

        public void addNewActivity(Activity newActivity)
        {
            _activity.Add(newActivity);
        }

        public void deleteActivity()
        {

        }

        public Activity checkHasActivity(DateTime today)
        {
            foreach(Activity activity in _activity)
            {
                if (activity.Date == today)
                {
                    return activity;
                }
            }
            
            return new Activity();
        }

    }
}
