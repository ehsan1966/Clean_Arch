using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Application.Interface;
using CleanArch.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Clean.Controllers
{
    public class CoursesController : Controller
    {
        private ICourseService _courseService;
        public CoursesController(ICourseService courseService)
        {
            _courseService = courseService;
        }
        public IActionResult Index()
        {
            CourseViewModel model = _courseService.GetCourse();
            return View(model);
        }
    }
}