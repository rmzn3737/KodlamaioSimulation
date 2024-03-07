using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Core;
using Core.Entities.Concrete;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
<<<<<<< HEAD
        AccessToken
            CreateToken(User user,
                List<OperationClaim> operationClaims); //User için token oluştur ve içine List<OperationClaim> yetkilerini koy.
=======
        AccessToken CreateToken(User  user,List<OperationClaim> operationClaims); 
>>>>>>> 38c9e1766a1f7d11db1ba62717a781d30cc0a39d
    }
}
