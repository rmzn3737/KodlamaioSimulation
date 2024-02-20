using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOConsoleSimulation.DataAcsess.Abstract
{
    internal interface ICategoryDal
    {
        void Add();
        void Update();
        void Delete();
    }
}
