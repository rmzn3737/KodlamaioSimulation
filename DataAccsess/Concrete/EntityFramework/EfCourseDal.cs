using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccsess.EntityFramework;
using DataAccsess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccsess.Concrete.EntityFramework
{
    public class EfCourseDal:EfEntityRepositoryBase<Course, CourseContext>,ICourseDal
    {
        
    }
}
