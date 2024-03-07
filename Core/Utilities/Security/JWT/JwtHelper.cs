<<<<<<< HEAD
﻿
using Core.Entities.Concrete;
using Core.Utilities.Security.Encrytion;
=======
﻿using Azure.Core;
using Core.Entities.Concrete;
using Core.Utilities.Security.Encryption;
>>>>>>> 38c9e1766a1f7d11db1ba62717a781d30cc0a39d
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD

using Azure.Core;
using Core.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
=======
using Microsoft.Extensions.Configuration;
using Core.Extensions;
>>>>>>> 38c9e1766a1f7d11db1ba62717a781d30cc0a39d

namespace Core.Utilities.Security.JWT
{
    public class JwtHelper : ITokenHelper
    {
<<<<<<< HEAD
        public IConfiguration Configuration { get; }//Bizim apimizdeki appsettings dosyasındaki değerleri okumamıza yarıyor.

        private TokenOptions _tokenOptions;//Okuduğumuz değerleri bu nesneye atacağız.
        private DateTime _accessTokenExpiration;//Jwt ne zaman etkisizleşecek.
=======
        public IConfiguration Configuration { get; }
        private TokenOptions _tokenOptions;
        private DateTime _accessTokenExpiration;
>>>>>>> 38c9e1766a1f7d11db1ba62717a781d30cc0a39d
        public JwtHelper(IConfiguration configuration)
        {
            Configuration = configuration;
            _tokenOptions =
<<<<<<< HEAD
                Configuration
                    .GetSection(
                        "TokenOptions").Get<TokenOptions>();//appsettingste tokenoptions sectionundaki değerleri alıp bizim oluşturduğumuz TokenOptions sınıfının değerlerine mapliyyor, yanai atıyor.

        }

=======
                Configuration.GetSection("TokenOptions").Get<TokenOptions>(); 

        }
        
>>>>>>> 38c9e1766a1f7d11db1ba62717a781d30cc0a39d
        public AccessToken CreateToken(User user, List<OperationClaim> operationClaims)
        {
            _accessTokenExpiration = DateTime.Now.AddMinutes(_tokenOptions.AccessTokenExpiration);
            var securityKey = SecurityKeyHelper.CreateSecurityKey(_tokenOptions.SecurityKey);
            var signingCredentials = SigningCredentialsHelper.CreateSigningCredentials(securityKey);
            var jwt = CreateJwtSecurityToken(_tokenOptions, user, signingCredentials, operationClaims);
            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            var token = jwtSecurityTokenHandler.WriteToken(jwt);

            return new AccessToken
            {
                Token = token,
                Expiration = _accessTokenExpiration
            };

<<<<<<< HEAD
            //throw new NotImplementedException();
        }
        
=======
        }
>>>>>>> 38c9e1766a1f7d11db1ba62717a781d30cc0a39d

        public JwtSecurityToken CreateJwtSecurityToken(TokenOptions tokenOptions, User user,
            SigningCredentials signingCredentials, List<OperationClaim> operationClaims)
        {
            var jwt = new JwtSecurityToken(
                issuer: tokenOptions.Issuer,
                audience: tokenOptions.Audience,
                expires: _accessTokenExpiration,
                notBefore: DateTime.Now,
                claims: SetClaims(user, operationClaims),
                signingCredentials: signingCredentials
            );
            return jwt;
        }

        private IEnumerable<Claim> SetClaims(User user, List<OperationClaim> operationClaims)
        {
            var claims = new List<Claim>();
            claims.AddNameIdentifier(user.Id.ToString());
            claims.AddEmail(user.Email);
            claims.AddName($"{user.FirstName} {user.LastName}");
            claims.AddRoles(operationClaims.Select(c => c.Name).ToArray());

            return claims;
        }
<<<<<<< HEAD


=======
>>>>>>> 38c9e1766a1f7d11db1ba62717a781d30cc0a39d
    }
}
