using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T>:DataResult<T> //İşlem sonucunu default true vereceğiz.
    {
        //Bunlar versiyonlar, programcının tercihine bırakıyoruz. Son iki constructor çok fazla kullanılımaz.
        public SuccessDataResult(T data, string message):base(data,true,message)
        {
            
        }

        public SuccessDataResult(T data):base(data,true)
        {
            
        }

        public SuccessDataResult(string message):base(default,true,message)
        {
            
        }

        public SuccessDataResult():base(default,true)
        {
            
        }
    }
}
