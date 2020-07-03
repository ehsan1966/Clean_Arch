using CleanArch.Application.Interface;
using CleanArch.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.Service
{
    public class CourseService : ICourseService
    {
        private ICourseService _courseService;
        public CourseService(ICourseService courseService)
        {
            _courseService = courseService;
        }


        public CourseViewModel GetCourse()
        {
            return _courseService.GetCourse();
        }
    }
}
