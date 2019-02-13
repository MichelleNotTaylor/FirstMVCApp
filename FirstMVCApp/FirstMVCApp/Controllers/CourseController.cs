using FirstMVCApp.Models;
using System.Web.Mvc;
using Week2.Shared.Enums;
using Week2.Shared.Orchestrators;

namespace FirstMVCApp.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        public ActionResult Index()
        {
            var courseOrchestrator = new CourseOrchestrator();

            var semesterModel = new SemesterModel
            {
                Courses = courseOrchestrator.GetAllCourses(),
                Semester = SemesterEnum.Fall,
                Year = 2019
            };
            
            return View(semesterModel);
        }
    }
}