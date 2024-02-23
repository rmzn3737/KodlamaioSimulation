using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace DataAccsess.Concrete.EntityFramework
{
    public class CourseContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\MSSQLLocalDB;Database=KodlamaioCourse;Integrated Security=True");//Server=(localdb)\MSSQLLocalDB;Database=KodlamaioCourse;Integrated Security=True;
                                                                                                    // "Server=(localdb)\\MSSQLLocalDB;Database=KodlamaioCourse;Trusted_Connection=True"
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
    }
}
