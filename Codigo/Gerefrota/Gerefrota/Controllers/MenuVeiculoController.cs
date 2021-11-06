using Domain.Abstract.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Gerefrota.Controllerda
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MenuVeiculoController : ControllerBase
    {
        private readonly IVistoriaService _vistoriaService;
        public MenuVeiculoController(IVistoriaService vistoriaService) => (_vistoriaService) = (vistoriaService);

        [HttpGet("{idVeiculo}")]
        public IActionResult Get(int idVeiculo) => Ok(idVeiculo);
    }
}