using Domain.Abstract.Services;
using Domain.Models.Auxs;
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
        private UserAndTypeModel _usuarioLogado;
        public CondutorController(IMotoristaService motoristaService) => _motoristaService = motoristaService;

        [HttpGet]
        public IActionResult Get()
        {
            _usuarioLogado = ((ClaimsIdentity)User.Identity).GetIdentityUser();
            var motoristas = _motoristaService.ObterMotoristasPorUnidade(_usuarioLogado.Usuario.IdUnidade);
            return Ok(motoristas);
        }
    }
}
