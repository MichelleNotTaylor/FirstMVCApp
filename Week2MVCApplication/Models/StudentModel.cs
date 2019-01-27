using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Week2.Shared.Enums;

namespace Week2MVCApplication.Models
{
	public class StudentModel
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public GenderEnum GenderType { get; set; }
		public String GenderName => GenderType.ToString();
		public int StudentAge { get; set; }
		public String StudentMajor { get; set; }
	}
}