﻿using CleanArch.Application.Interface;
using CleanArch.Application.Service;
using CleanArch.Data.Repository;
using CleanArch.Domains.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArc.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection service)
        {
            //Application Layer
            service.AddScoped<ICourseService, CourseService>();

            //Infra Data Layer
            service.AddScoped<ICourseRepository, CourseRepository>();

        }
    }
}
