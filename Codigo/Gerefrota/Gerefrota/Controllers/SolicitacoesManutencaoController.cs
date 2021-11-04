using Domain.Abstract.Services;
using Microsoft.AspNetCore.Mvc;

namespace Gerefrota.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SolicitacoesManutencaoController : ControllerBase
    {

        private readonly ISolicitacoesManutencaoService _solicitacoesManutencaoService;
        public SolicitacoesManutencaoController(ISolicitacoesManutencaoService solicitacoesManutencaoService)
        {
            _solicitacoesManutencaoService = solicitacoesManutencaoService;
        }

        [HttpGet]
        public IActionResult Get() => Ok(_solicitacoesManutencaoService.GetAll());

    }
}
