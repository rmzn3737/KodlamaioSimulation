using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccsess;
using Entities.DTOs;

namespace DataAccsess.Abstract
{
    public interface ICourseDal:IEntityRepository<Course>
    {
        List<CourseDetailDto> GetCourseDetails();
    }
}
