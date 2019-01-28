using MvcIntroApp.Shared.Orchestrators.Interfaces;
using MvcIntroApp.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcIntroApp.Shared.Orchestrators
{
    public class CourseOrchestrator : ICourseOrchestrator
    {
        public List<CourseViewModel> GetAllCourses()
        {
            var courses = new List<CourseViewModel>
            {
                new CourseViewModel
                {
                    Capacity = 30,
                    CourseName = "Advanced C#",
                    CourseNumber = 174,
                    Department = "CIS"
                },
                new CourseViewModel
                {
                    Capacity = 30,
                    CourseName = "Intro to Game Design",
                    CourseNumber = 140,
                    Department = "CIS"

                }
            };
            return courses;
        }
    }
}
