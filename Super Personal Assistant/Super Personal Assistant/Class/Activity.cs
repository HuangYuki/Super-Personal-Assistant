using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Super_Personal_Assistant
{
 
    class Activity
    {
        private DateTime _date;
        private String _description;

        //Attribute
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
        //Attribute
        public String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        //初始化
        public Activity(DateTime date,String task)
        {
            _date = date;
            _description = task;
        }
        //初始化
        public Activity()
        {
            _date = DateTime.Today;
            _description = "";
        }

        //function
        public static DateTime StringToDate(String input)
        {
            String[] aa = input.Split('/');
            DateTime date = new DateTime(int.Parse(aa[0]), int.Parse(aa[1]), int.Parse(aa[2]));
            return date;
        }
    }
}
