using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Week2.Shared.Orchestrators;
using Week2MVCApplication.Models;

namespace Week2MVCApplication.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
			var studentOrchestrator = new StudentOrchestrator();
			var studentModel = new StudentModel
			{
				FirstName = "Princess",
				LastName = "Mae",
				GenderType = Week2.Shared.Enums.GenderEnum.Female,
				StudentAge = 22,
				StudentMajor = "Cosmetology"
			};

            return View(studentModel);
        }
    }
}