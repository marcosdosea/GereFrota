using Domain.Abstract.Services;
using Microsoft.AspNetCore.Mvc;


namespace Gerefrota.Controllers
{
    [Route("Api/[controller]")]
    [ApiController]
    public class RelatorioMecanicoController : ControllerBase
    {
        private readonly IRelatorioMecanicoService _relatorioMecanicoService;

        public RelatorioMecanicoController(IRelatorioMecanicoService relatorioMecanicoService)
        {
            _relatorioMecanicoService = relatorioMecanicoService;
        }

        [HttpGet]
        public IActionResult Get() => Ok(_relatorioMecanicoService.GetAll());
    }
}
