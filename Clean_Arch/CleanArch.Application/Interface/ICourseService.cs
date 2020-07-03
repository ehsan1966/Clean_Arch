using CleanArch.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.Interface
{
   public interface ICourseService
    {
        CourseViewModel GetCourse();
    }
}
