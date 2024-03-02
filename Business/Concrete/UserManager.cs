using Business.Abstract;
using Core.Entities.Concrete;
using DataAccsess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)//UserDal ı enjecte ediyor.
        {
            _userDal = userDal;
        }

        public List<OperationClaim> GetClaims(User user)//UserDal dan claimleleri çekiyor.
        {
            return _userDal.GetClaims(user);
        }

        public void Add(User user)//User ekleme yapıyor.
        {
            _userDal.Add(user);
        }

        public User GetByMail(string email)//e-Maile göre getiriyor.
        {
            return _userDal.Get(u => u.Email == email);
        }
    }
}
