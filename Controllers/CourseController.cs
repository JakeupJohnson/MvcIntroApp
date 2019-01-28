using MvcIntroApp.Models;
using MvcIntroApp.Shared.Enums;
using MvcIntroApp.Shared.Orchestrators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcIntroApp.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        public ActionResult Index()
        {
            var courseOrchestrator = new CourseOrchestrator();

            var model = new SemesterModel
            {
                Year = 2019,
                Semester = SemesterEnum.Spring,
                Courses = courseOrchestrator.GetAllCourses()
            };

            return View(model);
        }
    }
}