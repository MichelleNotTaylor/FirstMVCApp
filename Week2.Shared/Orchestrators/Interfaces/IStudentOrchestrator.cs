using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2.Shared.ViewModels;

namespace Week2.Shared.Orchestrators.Interfaces
{
	public interface IStudentOrchestrator
	{
		List<StudentViewModel> GetAllStudents();
	}
}
