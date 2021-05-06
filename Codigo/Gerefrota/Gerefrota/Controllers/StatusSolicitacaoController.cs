using Domain.Abstract.Services;
using Microsoft.AspNetCore.Mvc;

namespace Gerefrota.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class StatusSolicitacaoController : ControllerBase
    {
        private readonly IStatusSolicitacaoService _statusSolicitacaoService;

        public StatusSolicitacaoController(IStatusSolicitacaoService statusSolicitacaoService)
        {
            _statusSolicitacaoService = statusSolicitacaoService;
        }

        [HttpGet]
        public IActionResult Get() => Ok(_statusSolicitacaoService.GetAll());
    }
}
