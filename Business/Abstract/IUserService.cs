using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);//Claimleri getir.
        void Add(User user);//Kullanıcı ekle.
        User GetByMail(string email);//e-maile göre kullanıcı getir.
    }
}
