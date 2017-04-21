using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Super_Personal_Assistant
{
 
    class Schedule
    {
        private DateTime _date;
        private String _activity;

        public Schedule(DateTime date,String task)
        {
            _date = date;
            _activity = task;
        }

        public Schedule()
        {
            _date = DateTime.Today;
            _activity = "";
        }

        public void SetDate(DateTime date)
        {
            _date = date;
        }

        public void SetTask(String task)
        {
            _activity = task;
        }


        public static DateTime StringToDate(String input)
        {
            String[] aa = input.Split('/');
            DateTime date = new DateTime(int.Parse(aa[0]), int.Parse(aa[1]), int.Parse(aa[2]));
            return date;
        }
    }
}
