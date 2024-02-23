using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccsess.Abstract;
using Entities.Concrete;

namespace DataAccsess.Concrete.InMemory
{
    public class InMemoryCourseDal:ICourseDal
    {
        private List<Course> _courses;//Class için global değişken.
        //Alt çizgi bu yöntem için //isimlendirme standardı oluyor.
        //İngilizcesi naming.
        public InMemoryCourseDal()
        {
            //Oracle,Sql Server, Postgres, Mongo DB vb.
            _courses = new List<Course>
            {
                new Course {CourseId = 1,CategoryId = 1,CourseName = "2024 - Yazılım Geliştirici Yetiştirme Kampı C#",CourseDescription = "Sıfırdan başlayıp yepyeni bir metodolojiyle profesyonelleşeceksiniz.",Price = 0},
                new Course {CourseId = 2,CategoryId = 2,CourseName = "Programlamaya Giriş İçin Temel Kurs",CourseDescription ="PYTHON, JAVA, C# gibi tüm programlama dilleri için temel programlama mantığını anlaşılır örneklerle öğrenin.", Price = 0},
                new Course {CourseId = 3,CategoryId = 3,CourseName = "(2022) Yazılım Geliştirici Yetiştirme Kampı (JAVA)",CourseDescription = "Profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz.",Price = 0},
                new Course {CourseId = 4,CategoryId = 3,CourseName = "Yazılım Geliştirici Yetiştirme Kampı (JavaScript)",CourseDescription = "1,5 ay sürecek ücretsiz ve profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz.",Price = 0},
                new Course {CourseId = 5,CategoryId = 2,CourseName = "(2023) Yazılım Geliştirici Yetiştirme Kampı (Python & Selenium)",CourseDescription = "Profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz.",Price = 0}
            };
        }
        public List<Course> GetAll()
        {
            return _courses; //throw new NotImplementedException();
        }

        public List<Course> GetAll(Expression<Func<Course, bool>> fliter = null)
        {
            throw new NotImplementedException();
        }

        public Course Get(Expression<Func<Course, bool>> fliter)
        {
            throw new NotImplementedException();
        }

        public void Add(Course course)
        {
            _courses.Add(course);
            //throw new NotImplementedException();
        }

        public void Update(Course course)
        {
            //Gönderdiğim Ürün Id'sine sahip olan ürünü listede bul.
            Course courseToUpdate = _courses.SingleOrDefault(c => c.CourseId == course.CourseId);
            courseToUpdate.CourseName=course.CourseName;
            courseToUpdate.CategoryId=course.CategoryId;
            courseToUpdate.CourseDescription=course.CourseDescription;
            courseToUpdate.Price=course.Price;
            //throw new NotImplementedException();
        }

        public void Delete(Course course)
        {
            //LINQ - Language Integrated Query
            //Lambda işareti =>
            /*Course courseToDelete = null;
            foreach (var c in _courses)//LİNQ kullanılmayan yöntem
            {
                if (course.CourseId ==c.CourseId)
                {
                    courseToDelete = c;
                    
                }
                
            }*/

            Course courseToDelete = _courses.SingleOrDefault(c=>c.CourseId==course.CourseId);
            //First,FirstOrDefault,SingleOrDefault bizim şuanki durumumuz için bunlardan birini kullanailiriz.
            //Aynı listede Single da var o da belki olabilir, denemedim.
            _courses.Remove(courseToDelete);
            //throw new NotImplementedException();
        }

        public List<Course> GetAllByCategory(int categoryId)
        {
            return _courses.Where(c=>c.CourseId== categoryId).ToList();
            //Where koşulu içindeki şarta uyan bütün elemanları yeni bir liste
            //haline getirir ve döndürür. Buraya istediğin kadar koşul
            //yazabilirsin. Sql deki where koşulu gibi.
            //throw new NotImplementedException();
        }
    }
}
