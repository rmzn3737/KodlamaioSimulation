using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccsess.EntityFramework;
using DataAccsess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccsess.Concrete.EntityFramework
{
    public class EfCourseDal:EfEntityRepositoryBase<Course, CourseContext>,ICourseDal
    {
        public List<CourseDetailDto> GetCourseDetails()
        {
            using (CourseContext context = new CourseContext())
            {
                var result =
                    from crs in context.Courses
                    join c in context.Categories 
                        on crs.CategoryId equals c.CategoryId
                    select new CourseDetailDto{ 
                        CourseId = crs.CourseId,
                        CourseName = crs.CourseName,
                        CategoryName = c.CategoryName,
                        CourseDescription = crs.CourseDescription,

                    };
                return result.ToList();
            }
        }
    }
}
