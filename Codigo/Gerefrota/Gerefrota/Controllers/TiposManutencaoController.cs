using Domain.Abstract.Services;
using Microsoft.AspNetCore.Mvc;

namespace Gerefrota.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TiposManutencaoController : ControllerBase
    {
        private readonly ITiposManutencaoService _tiposManutencaoService;
        public TiposManutencaoController(ITiposManutencaoService tiposManutencaoService)
        {
            _tiposManutencaoService = tiposManutencaoService;
        }

        [HttpGet]
        public IActionResult Get() => Ok(_tiposManutencaoService.GetAll());
    }
}
