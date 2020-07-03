using CleanArch.Domains.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Data.Context
{
    public class UniversityDbContext : DbContext
    {

        public UniversityDbContext(DbContextOptions<UniversityDbContext> options) : base(options)
        {

        }

        public DbSet<Course> Courses { get; set; }

    }
}
