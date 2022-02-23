using Domain.Models;
using Domain.Models.Auxs;
using System.Linq;
using System.Security.Claims;

namespace Gerefrota.Extensions.Identity
{
    public static class GetIdentityUserExtension
    {
        /// <summary>
        /// Obtem usuario logado na aplicação, obtendo as informações do token passado.
        /// </summary>
        /// <param name="userIdentity"></param>
        /// <returns></returns>
        public static UserAndTypeModel GetIdentityUser(this ClaimsIdentity userIdentity)
        {
            var claims = userIdentity.Claims;
            var userAndType = new UserAndTypeModel
            {
                Usuario = new UsuarioModel
                {
                    Id = int.Parse(claims.FirstOrDefault(c => c.Type == ClaimTypes.Sid).Value),
                    Nome = claims.FirstOrDefault(c => c.Type == ClaimTypes.Name).Value,
                    Email = claims.FirstOrDefault(c => c.Type == ClaimTypes.Email).Value,
                    Telefone = claims.FirstOrDefault(c => c.Type == ClaimTypes.MobilePhone).Value,
                    IdTipoUsuario = int.Parse(claims.FirstOrDefault(c => c.Type == ClaimTypes.PrimarySid).Value),
                    IdUnidade = int.Parse(claims.FirstOrDefault(c => c.Type == ClaimTypes.PrimaryGroupSid).Value),
                },
                TipoUsuario = new TipoUsuarioModel
                {
                    Id = int.Parse(claims.FirstOrDefault(c => c.Type == ClaimTypes.PrimarySid).Value),
                    Descricao = claims.FirstOrDefault(c => c.Type == ClaimTypes.Role).Value
                }
            };

            return userAndType;
        }
    }
}
