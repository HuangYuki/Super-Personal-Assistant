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
            String[] aa = input.Split('/');
            DateTime date = new DateTime(int.Parse(aa[0]), int.Parse(aa[1]), int.Parse(aa[2]));
            return date;
        }

    }
}
