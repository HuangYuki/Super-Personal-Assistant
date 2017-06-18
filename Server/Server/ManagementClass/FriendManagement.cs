using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.ManagementClass
{
    class FriendManagement
    {
        public String[] seperateData(string data) //分離資料
        {
            char space = '_';
            string[] words = null;

            words = data.Split(space);

            return words;
        }

        public List<String> InitiallizeFreind(string msg) //初始化訊息
        {
            List<string> tmp = new List<string>();

            string path = msg + "Friend";
            StreamReader sr = new StreamReader(@"../../DataStorage/Friend/" + path + ".txt");
            while (!sr.EndOfStream) //如果沒有到結數字元
            {
                string line = sr.ReadLine();
                tmp.Add(line);
            }
            sr.Close();

            return tmp;
        }
    }
}
