using System.Web.Mvc;

namespace FirstMVCApp.Controllers
{
	public class CourseController : Controller
    {
        // GET: Course
        public ActionResult Index()
        {
            return View();
        }
    }
}