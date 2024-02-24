using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;


namespace Entities.Concrete
{
    public class Course:IEntity
    {
        public int CourseId { get; set; }   
        public int CategoryId { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public decimal Price { get; set; }
    }
}
