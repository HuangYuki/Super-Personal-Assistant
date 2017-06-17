using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_Personal_Assistant
{
	public static class Tool
	{
		public static bool IsNaturalNumber(this string str)
		{
			System.Text.RegularExpressions.Regex reg1 = new System.Text.RegularExpressions.Regex(@"^[A-Za-z0-9]+$");
			return reg1.IsMatch(str);
		}

        
        public static DateTime StringToDate(String input)
        {
            String[] splitSlash = input.Split('/');
            DateTime date = new DateTime(int.Parse(splitSlash[0]), int.Parse(splitSlash[1]), int.Parse(splitSlash[2]));
            return date;
        }

        public static DateTime StringToTime(String input)
        {
            string[] splitColon = input.Split(':');
            DateTime time = new DateTime(2000, 1, 1, int.Parse(splitColon[0]), int.Parse(splitColon[1]), 0);
            return time;
        }

    }
}
