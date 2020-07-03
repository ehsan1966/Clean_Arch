using CleanArch.Domains.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Domains.Interface
{
   public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
    }
}
