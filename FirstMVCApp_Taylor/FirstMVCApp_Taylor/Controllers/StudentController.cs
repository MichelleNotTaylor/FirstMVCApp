using FirstApp.Shared.Enums;
using FirstMVCApp_Taylor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCApp_Taylor.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            var studentModel = new StudentModel
            {
                FirstName = "Michelle",
                LastName = "Taylor",
                Gender = GenderEnum.Female,
                Age = 24,
                Major = "Business Information Systems"
            };

            return View(studentModel);
        }
    }
}