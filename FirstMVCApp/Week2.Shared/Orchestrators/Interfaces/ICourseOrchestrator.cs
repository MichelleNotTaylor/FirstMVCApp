using System.Collections.Generic;
using Week2.Shared.ViewModels;

namespace Week2.Shared.Orchestrators.Interfaces
{
    public interface ICourseOrchestrator
    {
        List<CourseViewModel> GetAllCourses();
    }
}
