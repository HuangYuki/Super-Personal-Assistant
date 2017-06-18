using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.ManagementClass
{
    class MessageManagement
    {
        public String[] seperateData(string data) //分離資料
        {
            char space = '_';
            string[] words = null;

            words = data.Split(space);

            return words;
        }

        public List<String> InitiallizeFreindMessage(string msg) //初始化訊息
        {
            List<string> tmp = new List<string>();
            String[] words = null;
            words = seperateData(msg);

            string path = words[1] + "Message/" + words[1] + words[2];
            StreamReader sr = new StreamReader(@"../../DataStorage/Message/" + path + ".txt");
            while (!sr.EndOfStream) //如果沒有到結數字元
            {
                string line = sr.ReadLine();
                tmp.Add(line);
            }
            sr.Close();

            return tmp;
        }

        public void saveMessage(string[] words)
        {
            string path = words[1] + "Message/" + words[1] + words[2];
            StreamWriter sw = new StreamWriter(@"../../DataStorage/Message/" + path + ".txt", true);
            sw.WriteLine("YOU : " + words[3]);
            sw.Close();

            string path2 = words[2] + "Message/" + words[2] + words[1];
            StreamWriter sw2 = new StreamWriter(@"../../DataStorage/Message/" + path2 + ".txt", true);
            sw2.WriteLine(words[2] + " : " + words[3]);
            sw2.Close();
        }
    }
}
