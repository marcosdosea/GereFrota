using Domain.Abstract.Services;
using Domain.Models;
using Domain.Models.Auxs.DTO;
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
        private readonly IComponenteService _componenteService;
        public MenuVeiculoController(IVistoriaService vistoriaService,
            IVeiculoService veiculoService,
            IAbastecimentoService abastecimentoService,
            IViagemService viagemService, IComponenteService componenteService)
        {
            _vistoriaService = vistoriaService;
            _veiculoService = veiculoService;
            _abastecimentoService = abastecimentoService;
            _viagemService = viagemService;
            _componenteService = componenteService;
        }

        [HttpGet("{idVeiculo}")]
        public IActionResult Get(int idVeiculo) => Ok(_veiculoService.Get(x => x.Id == idVeiculo));

        [HttpPost("realizarAbastecimento")]
        public IActionResult PostAbastecimento([FromBody] AbastecimentoModel abastecimento) => Ok(_abastecimentoService.Insert(abastecimento));

        [HttpPost("registrarSaida")]
        public IActionResult PostSaida([FromBody] ViagemModel viagem) => Ok(_viagemService.Insert(viagem));

        #region VISTORIA
        [HttpGet("realizarVistoria/{idVeiculo}")]
        public IActionResult GetVistoria(int idVeiculo)
        {
            var componentes = _componenteService.GetAll();
            var veiculo = _veiculoService.Get(v => v.Id == idVeiculo);
            return Ok(new { veiculo, componentes });
        }

        [HttpPost("realizarVistoria")]
        public IActionResult PostVistoria([FromBody] VistoriaDTO vistoria) => Ok(_vistoriaService.Insert(vistoria));
        #endregion
    }
}