using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccsess.Abstract;
using DataAccsess.Concrete.InMemory;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CourseManager:ICourseService
    {
        ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public List<Course> GetAll()
        {
            
            //İş Kodları
            //Yetkisi var mı ? İf kodları
            //Kural bir iş sınıfı başka sınıfları newlemez.
            return _courseDal.GetAll();
            //throw new NotImplementedException();
        }
    }
}
