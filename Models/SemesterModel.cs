using MvcIntroApp.Shared.Enums;
using MvcIntroApp.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcIntroApp.Models
{
    public class SemesterModel
    {
        public int Year { get; set; }
        public SemesterEnum Semester { get; set; }
        public string SemesterName => Semester.ToString();
        public List<CourseViewModel> Courses { get; set; }
    }
}