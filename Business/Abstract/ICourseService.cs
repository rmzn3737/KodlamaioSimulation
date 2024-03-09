using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICourseService
    {
        IDataResult <List<Course>> GetAll();//Bu işlem sonucunu, mesajı ve de daha önceki metodun döndürdüğü mesajı da içeren bir yapı görevi görüyor.
        IDataResult<List<Course>>  GetAllByCategoryId(int id);
        IDataResult<List<Course>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<CourseDetailDto>> GetCourseDetails();
        IDataResult<Course> GetByID(int courseId);//Bir siteye girdik ve bir ürünün detayına bakmak istedik, tıkladığımızda sayfa sadece o ürünün bilgilerini içerecek şekilde güncelleniyor, işte o zaman bu metodu çağırıyoruz.
        IResult Add(Course course);
        //RESTFUL ------>HTTP
        IResult Update(Course course);

        //IResult AddTransactionalTest(Course course);//Transactional uygulamalarda tutarlılığı korumak için yapılan bir yöntem. Örnek banka seabından para çekme işlemleri.
    }
}
