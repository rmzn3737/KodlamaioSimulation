using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result:IResult
    {
        

        public Result(bool succses, string message):this(succses)//İki constructoru birden çalıştırıyor. Constructorun Base'ler veya kendi içindeki yapılarla çalışmasına güzel bir örnek.
        {
            Message=message;
        }

        public Result(bool succses)//Overloading yaptık, mesajsız şekilde yaptık.
        {
            Succses = succses;
        }

        public bool Succses { get; }
        public string Message { get; }
    }
}
