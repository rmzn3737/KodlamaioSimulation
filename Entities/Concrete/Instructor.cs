using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Instructor:IEntity
    {
        public int InstructorId { get; set; }
        public string InstuctorName { get; set; }
        public string InstructorLastname { get; set; }
        public string InstructorEmail { get; set; }
    }
}
