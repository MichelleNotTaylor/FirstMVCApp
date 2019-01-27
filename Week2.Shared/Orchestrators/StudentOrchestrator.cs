using System.Collections.Generic;
using Week2.Shared.ViewModels;
using Week2.Shared.Orchestrators.Interfaces;

namespace Week2.Shared.Orchestrators
{
	public class StudentOrchestrator : IStudentOrchestrator
	{
		public List<StudentViewModel> GetAllStudents()
		{
			var students = new List<StudentViewModel>
			{
				new StudentViewModel
				{
					FName = "Michelle",
					LName = "Taylor",
					Gender = Enums.GenderEnum.Female,
					Age = 24,
					Major = "Business Information Systems"
				},
				new StudentViewModel
				{
					FName = "Paul",
					LName = "McCoy",
					Gender = Enums.GenderEnum.Male,
					Age = 25,
					Major = "Network Administration"
				},
				new StudentViewModel
				{
					FName = "Bretman",
					LName = "Rock",
					Gender = Enums.GenderEnum.Male,
					Age = 19,
					Major = "Social Media Marketing"
				}
			};

			return students;
		}
	}
}
