using CleanArch.Application.Interface;
using CleanArch.Application.ViewModel;
using CleanArch.Domains.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.Service
{
    public class CourseService : ICourseService
    {
        private ICourseRepository _courseRepository;
        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }


        public CourseViewModel GetCourse()
        {
            return new CourseViewModel()
            {
                Courses = _courseRepository.GetCourses()
            };
        }
    }
}
