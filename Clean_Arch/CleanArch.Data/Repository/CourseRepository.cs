using CleanArch.Data.Context;
using CleanArch.Domains.Interface;
using CleanArch.Domains.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private UniversityDbContext _ctx;

        public CourseRepository(UniversityDbContext ctx)
        {
            _ctx = ctx;

        }

        public IEnumerable<Course> GetCourses()
        {
            return _ctx.Courses;
        }
    }


}
