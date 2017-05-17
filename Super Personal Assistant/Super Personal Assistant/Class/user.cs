using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Super_Personal_Assistant
{
	public class User
	{
		[Required(ErrorMessage = "輸入名字")]
		string _name { get; set; }

		[Required(ErrorMessage = "輸入名字")]
		string _account { get; set; }

		[Required(ErrorMessage = "輸入名字")]
		string _secret { get; set; }

		
	}
}
