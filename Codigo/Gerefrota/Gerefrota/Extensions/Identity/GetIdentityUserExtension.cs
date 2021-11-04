using Domain.Models;
using Domain.Models.Auxs;
using System.Linq;
using System.Security.Claims;

namespace Gerefrota.Extensions.Identity
{
    public static class GetIdentityUserExtension
    {
        public static UserAndTypeModel GetIdentityUser(this ClaimsIdentity userIdentity)
        {
            var claims = userIdentity.Claims;
            var roleClaimType = userIdentity.RoleClaimType;

            var userAndType = new UserAndTypeModel
            {
                Usuario = new UsuarioModel
                {
                    Id = int.Parse(claims.FirstOrDefault(c => c.Type == ClaimTypes.Sid).Value),
                    Nome = claims.FirstOrDefault(c => c.Type == ClaimTypes.Name).Value,
                    Email = claims.FirstOrDefault(c => c.Type == ClaimTypes.Email).Value,
                    Telefone = claims.FirstOrDefault(c => c.Type == ClaimTypes.MobilePhone).Value,
                    IdTipoUsuario = int.Parse(claims.FirstOrDefault(c => c.Type == ClaimTypes.Role).Value),

                    new Claim(ClaimTypes.Sid, user.Usuario.Id.ToString()),
                    new Claim(ClaimTypes.Name, user.Usuario.Nome),
                    new Claim(ClaimTypes.Email, user.Usuario.Email),
                    new Claim(ClaimTypes.MobilePhone, user.Usuario.Telefone),
                    new Claim(ClaimTypes.Role, user.TipoUsuario.Descricao),
                    new Claim(ClaimTypes.SerialNumber, user.Usuario.NumeroMatricula),
                    new Claim(ClaimTypes.PrimaryGroupSid, user.Usuario.IdUnidade.ToString())
                },
                TipoUsuario = new TipoUsuarioModel { }
            };

            var roles = claims.FirstOrDefault(c => c.Type == ClaimTypes.PrimaryGroupSid);

            return null;
        }
    }
}
