using Api.Domain.Dtos;
using Api.Domain.Interfaces.Services.User;
using Api.Domain.Repositories;
using Api.Domain.Security;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;

namespace Api.Service.Services
{
    public class LoginService : ILoginService
    {
        private readonly IUserRepository _repository;
        private readonly SigningConfig _signingConfig;

        public LoginService(IUserRepository repository, SigningConfig signingConfig)
        {
            _repository = repository;
            _signingConfig = signingConfig;
        }

        public async Task<object> FindByLogin(LoginDto user)
        {
            if (user != null && !string.IsNullOrWhiteSpace(user.Email))
            {
                var baseUser = await _repository.FindByLogin(user.Email);
                if (baseUser == null)
                {
                    return new
                    {
                        authenticated = false,
                        message = "Falha ao autenticar"
                    };
                }
                else
                    return ReturnAuthenticatedUser(user.Email);
            }
            return null;
        }

        private object ReturnAuthenticatedUser(string email)
        {
            var createDate = DateTime.UtcNow;
            var expirationDate = createDate + TimeSpan.FromSeconds(Convert.ToInt32(Environment.GetEnvironmentVariable("SECONDS")));

            return new
            {
                authenticated = true,
                createDate = createDate.ToString("yyy-MM-dd HH:mm:ss"),
                expirationDate = expirationDate.ToString("yyy-MM-dd HH:mm:ss"),
                accessToken = CreateToken(email, createDate, expirationDate),
                userName = email,
                message = "Usuário logado com sucesso"
            };
        }

        private object CreateToken(string email, DateTime createDate, DateTime expirationDate)
        {
            var identity = new ClaimsIdentity(
                        new GenericIdentity(email),
                        new[]
                        {
                            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                            new Claim(JwtRegisteredClaimNames.UniqueName, email)
                        });

            var handler = new JwtSecurityTokenHandler();

            var securityToken = handler.CreateToken(new SecurityTokenDescriptor
            {
                Issuer = Environment.GetEnvironmentVariable("ISSUER"),
                Audience = Environment.GetEnvironmentVariable("AUDIENCE"),
                SigningCredentials = _signingConfig.SigningCredentials,
                Subject = identity,
                NotBefore = createDate,
                Expires = expirationDate
            });

            return handler.WriteToken(securityToken);
        }
    }
}
