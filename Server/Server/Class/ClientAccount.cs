using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Class
{
    class ClientAccount
    {
        private String _id; //Server給的編號
        private String _account; //使用者帳號
        private String _passward; //使用者密碼
        private String _name; //使用者名稱
        private int _typeId; //重送的資料型態

        public ClientAccount()
        {
            _id = "";
            _account = "";
            _passward = "";
            _name = "";
            _typeId = 1;
        }

        public String Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public String Account //設定帳號
        {
            get { return _account; }
            set { _account = value; }
        }

        public String Passward //設定密碼
        {
            get { return _passward; }
            set { _passward = value; }
        }

        public String Name //設定名字
        {
            get { return _name; }
            set { _name = value; }
        }

        public int TypeId //回傳ID
        {
            get{ return _typeId; }
        }


    }
}
