using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Encrytion
{
    public class SigningCredentialsHelper
    {
        //CreateSigningCredentials
        public static SigningCredentials CreateSigningCredentials(SecurityKey securityKey)//WebApi nin kullanabilece JWT lerin oluşturulabilmesi için Elimizdeki yani kullanıcı adı parola bir Credentials dır. Burada elimizde SecurityKey var, o sisteme kullanabilmemiz için bir tane anahtara ihtiyacımız vardı ya credential dediğimiz bizim anahtarımız oluyor, o yüzden burada parametre olarak elimizdeki securityke securitykey formatında vereceğiz ve o da bize o imzalama nesnesi döndürüyor olacak. 
        {
            return new SigningCredentials(securityKey,SecurityAlgorithms.HmacSha512Signature);//Asp net e sen şimdi bir hashing işlemi yapacaksın anahtar olarak parametrenin içinde verdiğim bu securityKey kullan, şifreleme olarak da güvenlik algoritmalarından securityAlgorithms.HmacSha512Signature yi kullan diyoruz. Aslında bu sınıf web apiye, asp nete hangi anahtarı ve hangi algoritmayı kullanacağı bilgisini veriyor.
        }
    }
}

//Capilot'un açıklaması.
//Credential, Türkçe’de “delil”, “ehliyet”, “itimatname”, veya “yeterlilik belgesi” anlamlarına gelir 1. Genellikle yazılı formda sunulan bir kişinin kimliği, pozisyonu veya yetkisi hakkında bilgi içerir. Örneğin, basın kartı, ehliyet veya mesleki yeterlilik belgesi gibi deliller kişinin yetkisini veya niteliklerini gösterir. Kimlik doğrulama işlemlerinde de kullanılır.
