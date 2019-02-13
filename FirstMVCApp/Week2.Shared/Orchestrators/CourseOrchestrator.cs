using System.Collections.Generic;
using Week2.Shared.Orchestrators.Interfaces;
using Week2.Shared.ViewModels;

namespace Week2.Shared.Orchestrators
{
    public class CourseOrchestrator : ICourseOrchestrator
    {
        public List<CourseViewModel> GetAllCourses()
        {
            var courses = new List<CourseViewModel>
            {
                new CourseViewModel
                {
                    Capacity = 25,
                    CourseName = "Intro to C#",
                    CourseNumber = 169,
                    Department = "CIS"
                },
                new CourseViewModel
                {
                    Capacity = 30,
                    CourseName = "Advanced C#",
                    CourseNumber = 174,
                    Department = "CIS"
                }
            };

            return courses;
        }
    }
}
