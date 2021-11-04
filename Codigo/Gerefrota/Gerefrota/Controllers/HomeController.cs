using Domain.Abstract.Services;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Claims;

namespace Gerefrota.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IVeiculoService _veiculoService;
        public HomeController(IVeiculoService veiculoService) => _veiculoService = veiculoService;

        [HttpGet("{idFrota}")]
        public IActionResult Get(int idFrota)
        {
            var identity = User.Identity as ClaimsIdentity;
            var idUnidade = identity.Claims.Where(x => x.Type == ClaimTypes.PrimaryGroupSid).FirstOrDefault();
            return Ok(_veiculoService.ObterTodosVeiculosDaFrota(idFrota));
        }
    }
}
