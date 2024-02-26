using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]//C# da bunun adı Attribute, Java da ise Annatotation
    public class CoursesController : ControllerBase//Api isimlendirmelerinde Courses şeklinde çoğul verilir, onun için böyle yazdık.
    {
        [HttpGet]
        public List<Course> Get()
        {
            return new List<Course>
            {
                new Course
                {
                    CategoryId = 1, CourseId = 25, CourseName = "WEB APİ Course",
                    CourseDescription = "APİ leri Öğreniyoruz.", Price = 0
                },
                new Course
                {
                    CategoryId = 2, CourseId = 26, CourseName = "WEB APİ Course 2",
                    CourseDescription = "APİ leri Öğreniyoruz. 2", Price = 2
                },

            };
        }
    }
}
