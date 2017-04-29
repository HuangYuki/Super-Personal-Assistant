using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Super_Personal_Assistant.Class
{
    public class Account
    {
        private int _cost;
        private String _itemName;
        private DateTime _date;
        private int _id;

        //Attribute
        public int Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

        //Attribute
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public String ItemName
        {
            get { return _itemName; }
            set { _itemName = value; }
        }

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        //Constructor
        public Account()
        {

        }
        //Constructor
        public Account(int cost,String itemName,DateTime date)
        {
            _cost = cost;
            _itemName = itemName;
            _date = date;
        }
    }
}
