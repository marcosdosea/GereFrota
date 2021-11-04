using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Domain.Abstract.Services.Auxs;
using Domain.Models;
using Domain.Models.Auxs;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Services.Services.Auxs
{
    public class AuthService : IAuthService
    {
        private readonly IConfiguration _config;
        public AuthService(IConfiguration config) => _config = config;

        public string GenerateToken(UserAndTypeModel user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_config.GetValue<string>("AuthInfo:Secret"));
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Sid, user.Usuario.Id.ToString()),
                    new Claim(ClaimTypes.Name, user.Usuario.Nome),
                    new Claim(ClaimTypes.Email, user.Usuario.Email),
                    new Claim(ClaimTypes.MobilePhone, user.Usuario.Telefone),
                    new Claim(ClaimTypes.Role, user.TipoUsuario.Descricao),
                    new Claim(ClaimTypes.SerialNumber, user.Usuario.NumeroMatricula),
                    new Claim(ClaimTypes.PrimaryGroupSid, user.Usuario.IdUnidade.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}

