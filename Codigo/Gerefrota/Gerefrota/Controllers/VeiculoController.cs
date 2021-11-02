using Domain.Abstract.Services;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gerefrota.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculoController : ControllerBase
    {
        private readonly IVeiculoService _veiculoService;
        public VeiculoController(IVeiculoService veiculoService)
        {
            _veiculoService = veiculoService;
        }

        [HttpGet]
        public IActionResult Get() => Ok(_veiculoService.GetAll());

        [HttpGet("{idFrota}")]
        public IActionResult Get(int idFrota) => Ok(_veiculoService.ObterTodosVeiculosDaFrota(idFrota));

        [HttpPost]
        public IActionResult Post([FromBody] VeiculoModel veiculo) => Ok(_veiculoService.Insert(veiculo));
    }
}
