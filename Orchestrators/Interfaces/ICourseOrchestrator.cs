using MvcIntroApp.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcIntroApp.Shared.Orchestrators.Interfaces
{
    interface ICourseOrchestrator
    {
        List<CourseViewModel> GetAllCourses();
    }
}
