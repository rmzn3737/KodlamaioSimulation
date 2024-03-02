using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.JWT
{
    public class AccessToken//Kullanıcının bilgilerini girip elindeki tokenı da göndermesine accsess token deniliyor. Yani erişim anahtarı. Bir accsess tokenda string olarak anlamsız karakterlerler oluşturuluyor, burada bir de tokenın bitiş süresi yani Expiration vereceğiz.
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}
