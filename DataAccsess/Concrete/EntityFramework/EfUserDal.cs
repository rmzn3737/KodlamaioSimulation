using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccsess.EntityFramework;
using Core.Entities.Concrete;
using DataAccsess.Abstract;

namespace DataAccsess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, CourseContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new CourseContext())
            {
                var result = from operationClaim in context.OperationClaims
                    join userOperationClaim in context.UserOperationClaims
                        on operationClaim.Id equals userOperationClaim.OperationClaimId//Operation claimlerle useroparetion claimlere join atıyor
                    where userOperationClaim.UserId == user.Id//sonra id si bizim gönderdiğimiz id ye eşit olanı buluyor ve operation claim olarak da bunları return ediyoruz. Dolayısıyla CourseContex imize bizim db setlerimizi eklememiz gerekiyor.
                    select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();

            }
        }
    }
}
