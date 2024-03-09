using System;
using System.Collections.Generic;
using System.Diagnostics;
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
                try
                {
                    var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };

                    // Loglama işlemi burada yapılıyor
                    //Debug.WriteLine("Result Listesi:");
                    //foreach (var item in result)
                    //{
                    //    Debug.WriteLine($"Id: {item.Id}, Name: {item.Name}");
                    //}

                    return result.ToList();

                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    throw;
                }
                

            }
        }
    }
}
