using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccsess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccsess.Concrete.EntityFramework
{
    public class EfCourseDal:ICourseDal
    {
        public List<Course> GetAll(Expression<Func<Course, bool>> filter = null)
        {
            using (CourseContext context = new CourseContext())
            {
                return filter == null ? context.Set<Course>().ToList()
                    :context.Set<Course>().ToList();
            }
        }

        public Course Get(Expression<Func<Course, bool>> fliter)
        {
            using (CourseContext context= new CourseContext())
            {
                return context.Set<Course>().SingleOrDefault(fliter);
            }
        }

        public void Add(Course entity)
        {
            using (CourseContext context=new CourseContext())
            {
                var addedEntity=context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(Course entity)
        {
            using (CourseContext context = new CourseContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Course entity)
        {
            using (CourseContext context = new CourseContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
