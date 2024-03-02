using Core.DataAccsess;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess.Abstract
{
    public interface IUserDal : IEntityRepository<User>//Bu bir repoeistorydeki userın kullanılması, yani veri tabanındaki user'ın kullanılması.
    {
        List<OperationClaim> GetClaims(User user);//Burada bir join atılacağı için ekstradan bu metod konulmuş. Çünkü bir kullanıcının sisteme eklenmesi vb. zaten olacak, ancak aynı zamanda veritabanından kullanıcının claimlerini çekmek istiyoruz, operation claimlerini, onun için bunu yapıyoruz.
    }
}
