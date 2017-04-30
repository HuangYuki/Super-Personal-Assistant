using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Super_Personal_Assistant.Class
{
    class Friend
    {
        private int _id;
        private String _name;
        private String _account;
        private int _typeId;

        //Attribute
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        //Attribute
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }
        //Attribute
        public String Account
        {
            get { return _account; }
            set { _account = value; }
        }
        //Attribute
        public int  TypeId
        {
            get { return _typeId; }
            set { _typeId = value; }
        }

        public Friend()
        {
            
        }

        public Friend(int id,String name,String account,int typeId)
        {
            _id = id;
            _name = name;
            _account = account;
            _typeId = typeId;
        }

    }
}
