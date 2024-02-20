using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KodlamaIOConsoleSimulation.DataAcsess.Concrete;

namespace KodlamaIOConsoleSimulation.DataAcsess.Abstract
{
    internal interface IInstructorDal
    {
        List<Instructor> getAll();
        void Add(Instructor instructor);
        void Update(int Id );
        void Delete(Instructor instructor);
    }
}
