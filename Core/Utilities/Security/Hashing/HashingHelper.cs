using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Hashing
{

    public class HashingHelper
    {
        public static void CreatePasswordHash
            (string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

            }
        }

        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i])
                    {
                        return false;
                    }
                }
                return true;
            }


        }
    }


    //public class HashingHelper
    //{
    //    public static void CreatePasswordHash(string password,out byte[] passwordHash, out byte[] passwordSalt)//Bu kendisine verdiğimiz bir passwordun hashini oluşturacak.
    //    {
    //        using (var hmac = new System.Security.Cryptography.HMACSHA512())//Disposible Pattern ile yapacağız.
    //        {
    //            passwordSalt = hmac.Key;//Her kullanıcı için yeni bir key oluşturur, onun için oldukça güvenlidir.
    //            passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
    //        }

    //    }

    //    public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)//password hashini doğrula.Sen bunu yukarıdaki metoddaki kullandığın algoritma ile hashleseydin karşına burada parametre olarak verdiğimiz byte[] passwordHash gibi bir değer çıkar mıydı çıkmaz mıydı diye soruyoruz. İki hashi karşılaştırıp aynısysa true döndüreceğiz. Tabi tuzlamayı da devreye alıyoruz, çünkü parametrede o da var.
    //    {
    //        using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
    //        {//Bu verify metodundaki password kullanıcının girdiği parola, sisteme tekrardan girmeye çalışıyor.
    //           var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));//hesaplanan hash, burada oluşturulan hashte HMACSHA512(passwordSalt)) şuraya saltı verdiğimiz için saltı kullanarak bu hashi oluşturuyoruz. Burada oluşturulan değer bir byte[] array onun için for döngüsüyle karşılaştıracağız.
    //           for (int i = 0; i < computedHash.Length; i++)
    //           {
    //               if (computedHash[i] != passwordHash[i])//Burada gönderilen passwordun haslenmiş hali ile bizde kayıtlı olan hashi karşılaştırıyoruz.
    //               {
    //                   return false;
    //               }
    //           }
    //           return true;
    //        }

    //    }
    //}
}
