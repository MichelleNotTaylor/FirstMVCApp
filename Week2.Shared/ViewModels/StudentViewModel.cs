using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2.Shared.Enums;

namespace Week2.Shared.ViewModels
{
	public class StudentViewModel
	{
		public string FName { get; set; }
		public string LName { get; set; }
		public GenderEnum Gender { get; set; }
		public string GenderName => Gender.ToString();
		public int Age { get; set; }
		public string Major { get; set; }
	}
}
