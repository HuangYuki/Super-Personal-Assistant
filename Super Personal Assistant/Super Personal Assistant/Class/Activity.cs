using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Super_Personal_Assistant
{
 
    public class Activity
    {
        private DateTime _date;
        private String _title;
        private String _body;

        //Attribute
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
        //Attribute
        public String Title
        {
            get { return _title; }
            set { _title = value; }
        }
        //Attribute
        public String Body
        {
            get { return _body; }
            set { _body = value; }
        }

        //Constructor
        public Activity(DateTime date,String title,String body)
        {
            _date = date;
            _title = title;
            _body = body;
        }
        //Constructor
        public Activity()
        {
            _date = DateTime.Today;
            _title = _body = "";
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
