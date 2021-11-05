using Domain.Abstract.Services;
using Gerefrota.Extensions.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Gerefrota.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CondutorController : ControllerBase
    {
        private readonly IMotoristaService _motoristaService;
        public CondutorController(IMotoristaService motoristaService) => (_motoristaService) = (motoristaService);

        [HttpGet]
        public IActionResult Get()
        {
            var identity = User.Identity as ClaimsIdentity;
            var usuarioLogado = identity.GetIdentityUser();
            var motoristas = _motoristaService.ObterMotoristasPorUnidade(usuarioLogado.Usuario.IdUnidade);
            return Ok(motoristas);
        }
    }
}
