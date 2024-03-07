using Business.Constants;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Extensions;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
<<<<<<< HEAD
//using Castle.DynamicProxy;
=======
>>>>>>> 38c9e1766a1f7d11db1ba62717a781d30cc0a39d

namespace Business.BusinessAspects.Autofac
{
    public class SecuredOperation : MethodInterception
    {
        private string[] _roles;
        private IHttpContextAccessor _httpContextAccessor;

        public SecuredOperation(string roles)
        {
            _roles = roles.Split(',');
            _httpContextAccessor = ServiceTool.ServiceProvider.GetService<IHttpContextAccessor>();

        }

        protected override void OnBefore(IInvocation invocation)
        {
            var roleClaims = _httpContextAccessor.HttpContext.User.ClaimRoles();
<<<<<<< HEAD
            foreach (var role in _roles)//Kullanıcının rollerini gez, claimi varsa onbeforeu bitir, metodu döndür. Eğer yoksa AuthorizationDenied yetkin yok hatası döndür.
=======
            foreach (var role in _roles)
>>>>>>> 38c9e1766a1f7d11db1ba62717a781d30cc0a39d
            {
                if (roleClaims.Contains(role))
                {
                    return;
                }
            }
<<<<<<< HEAD
            throw new Exception(Messages.AuthorizationDenied);//AuthorizationDenied yetkin yok hatası.
=======
            throw new Exception(Messages.AuthorizationDenied);
>>>>>>> 38c9e1766a1f7d11db1ba62717a781d30cc0a39d
        }
    }
}
