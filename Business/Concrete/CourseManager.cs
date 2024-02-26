using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccsess.Abstract;
using DataAccsess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class CourseManager:ICourseService
    {
        ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public IDataResult<List<Course>> GetAll()
        {
            
            //İş Kodları
            //Yetkisi var mı ? İf kodları
            //Kural bir iş sınıfı başka sınıfları newlemez.
            if (DateTime.Now.Hour==16)//Yani sistem bu saatlerde bakımda.
            {
                return new ErrorDataResult<List<Course>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Course>>(_courseDal.GetAll(),Messages.CoursesListed) ;
            //throw new NotImplementedException();
        }

        public IDataResult<List<Course>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Course>>(_courseDal.GetAll(c => c.CategoryId == id));
        }

        public IDataResult<Course> GetByID(int courseId)
        {
            return new SuccessDataResult<Course>(_courseDal.Get(c => c.CourseId == courseId)) ;
        }

        public IDataResult<List<Course>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Course>> (_courseDal.GetAll(c => c.Price >= min && c.Price <= max));
        }

        public IDataResult<List<CourseDetailDto>>  GetCourseDetails()
        {
            if (DateTime.Now.Hour == 4)//Yani sistem bu saatlerde bakımda.Hoca yapmayın demişti!!!
            {
                return new ErrorDataResult<List<CourseDetailDto>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<CourseDetailDto>>(_courseDal.GetCourseDetails()) ;
        }

        public IResult Add(Course course)
        {
            //Business, yani iş kuralları buraya yazılacak, yani ürünü eklemeden önce yapılacak kontroller.

            if (course.CourseName.Length<2==true)//Biz burada bu şekilde yaptık ancak sektörde try catch bloğuyla da yapan kurumlar var, her iki yaklaşım da kullanılıyor.
            {
                return new ErrorResult(Messages.CourseNameInValid);//Kurs ismi en az 2 karakter olmalıdır."İleride stringi burada yamayacağız, magic strin demek oluyor bu.
            }
            _courseDal.Add(course);
            return new SuccessResult(Messages.CourseAdded);
        }
    }
}
