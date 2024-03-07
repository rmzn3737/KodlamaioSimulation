using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;

namespace Core.Utilities.Security.Encryption
{
    //Şifrelereme işlemleri olan her yerde bunları byt[] arrye şeklinde asp.net in anlayacağı şekilde vermemiz gerekiyor, basit bir string ile password oluşturamıyoruz.
    public class SecurityKeyHelper
    {
        public static SecurityKey CreateSecurityKey(string securityKey) //Burada bir SecurityKey döndürmemiz gerekiyor. Yani TokenOptions dosyasında oluşturduğumuz "mysupersecretkeymysupersecretkey" keyini.
        {
            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));//Burada kullandığımız bazı şeyleri daha sonra mutlaka araştıralım.
        }
    }
}
