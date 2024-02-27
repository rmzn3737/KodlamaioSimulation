using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccsess.Abstract;
using DataAccsess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using ValidationException = FluentValidation.ValidationException;

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

        [ValidationAspect(typeof(CourseValidator))]
        public IResult Add(Course course)
        {
            ////Business, yani iş kuralları buraya yazılacak, yani ürünü eklemeden önce yapılacak kontroller.
            
            //if (course.CourseName.Length<2==true)//Biz burada bu şekilde yaptık ancak sektörde try catch bloğuyla da yapan kurumlar var, her iki yaklaşım da kullanılıyor.
            //{
            //    return new ErrorResult(Messages.CourseNameInValid);//Kurs ismi en az 2 karakter olmalıdır."İleride stringi burada yamayacağız, magic strin demek oluyor bu.
            //}

            //validation
            //Cross Cutting Conserns
            //Log, cache, transaction, authorization, …  bunları araştıralım.
            //var context = new ValidationContext<Course>(course);//**Bu yöntem doğrulamanın en spagetti code yöntemi.
            //CourseValidator courseValidator = new CourseValidator();
            //var result = courseValidator.Validate(context);
            //if (!result.IsValid)
            //{
            //    throw new ValidationException(result.Errors);
            //}
            ////Loglama
            //Cacheremowe
            //Performance
            //Trnasaction
            //Yetkilendirme

            //ValidationTool.Validate(new CourseValidator(),course);
            _courseDal.Add(course);
            return new SuccessResult(Messages.CourseAdded);
        }
    }
}
