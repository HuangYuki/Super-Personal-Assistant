using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.ManagementClass
{
    class ScheduleManagement
    {
        public String[] seperateData(string data) //分離資料
        {
            char space = '_';
            string[] words = null;

            words = data.Split(space);

            return words;
        }

        public void saveScheduleItem(string msg)//儲存記帳資料
        {
            String[] words = null;
            words = seperateData(msg);

            string path = words[1] + "Schedule";

            if (msg[1] == '1')
            {
                StreamWriter sw = new StreamWriter(@"../../DataStorage/Schedule/" + path + ".txt");
                sw.WriteLine(msg);
                sw.Close();
            }
            else
            {
                StreamWriter sw = new StreamWriter(@"../../DataStorage/Schedule/" + path + ".txt", true);
                sw.WriteLine(msg);
                sw.Close();
            }
        }
        public List<String> InitiallizeSchedule(string msg) //初始化訊息
        {
            List<string> tmp = new List<string>();

            string path = msg + "Schedule";
            StreamReader sr = new StreamReader(@"../../DataStorage/Schedule/" + path + ".txt");
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
