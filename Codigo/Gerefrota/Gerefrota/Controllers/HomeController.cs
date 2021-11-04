using Domain.Abstract.Services;
using Gerefrota.Extensions.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Claims;

namespace Gerefrota.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class HomeController : ControllerBase
    {
        private readonly IVeiculoService _veiculoService;
        private readonly IFrotaService _frotaService;
        public HomeController(IVeiculoService veiculoService, IFrotaService frotaService) => (_veiculoService, _frotaService) = (veiculoService, frotaService);

        [HttpGet]
        public IActionResult Get()
        {
            var identity = User.Identity as ClaimsIdentity;
            var usuario = identity.GetIdentityUser();
            var frotas = _frotaService.ObterTodasAsFrotasPorUnidade(usuario.Usuario.IdUnidade);
            var veiculos = frotas.Select(f => _veiculoService.ObterTodosVeiculosDaFrota(f.Id));
            return Ok(veiculos);
        }
    }
}
