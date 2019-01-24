using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Shared.Orchestrators.Interfaces
{
	public interface ICourseOrchestrator
	{
		List<CourseViewModel> GetAllCourses();
	}
}
