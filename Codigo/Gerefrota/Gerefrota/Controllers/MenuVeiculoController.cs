using Domain.Abstract.Services;
using Domain.Models;
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
        private readonly IVeiculoService _veiculoService;
        private readonly IAbastecimentoService _abastecimentoService;
        private readonly IViagemService _viagemService;
        public MenuVeiculoController(IVistoriaService vistoriaService, IVeiculoService veiculoService, IAbastecimentoService abastecimentoService, IViagemService viagemService)
        {
            _vistoriaService = vistoriaService;
            _veiculoService = veiculoService;
            _abastecimentoService = abastecimentoService;
            _viagemService = viagemService;
        }

        [HttpGet("{idVeiculo}")]
        public IActionResult Get(int idVeiculo) => Ok(_veiculoService.Get(x => x.Id == idVeiculo));

        [HttpPost("realizarVistoria")]
        public IActionResult PostVistoria([FromBody] VistoriaModel vistoria) => Ok(_vistoriaService.Insert(vistoria));

        [HttpPost("realizarAbastecimento")]
        public IActionResult PostAbastecimento([FromBody] AbastecimentoModel abastecimento) => Ok(_abastecimentoService.Insert(abastecimento));

        [HttpPost("registrarSaida")]
        public IActionResult PostSaida([FromBody] ViagemModel viagem) => Ok(_viagemService.Insert(viagem));
    }
}