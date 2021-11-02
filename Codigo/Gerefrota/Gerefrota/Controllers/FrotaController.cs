using Domain.Abstract.Services;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gerefrota.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FrotaController : ControllerBase
    {
        private readonly IFrotaService _frotaService;
        public FrotaController(IFrotaService frotaService)
        {
            _frotaService = frotaService;
        }

        [HttpGet("{idUnidade}")]
        public IActionResult Get(int idUnidade) => Ok(_frotaService.ObterTodasAsFrotasPorUnidade(idUnidade));

        [HttpPost]
        public IActionResult Post([FromBody] FrotaModel frota) => Ok(_frotaService.Insert(frota));
    }
}
