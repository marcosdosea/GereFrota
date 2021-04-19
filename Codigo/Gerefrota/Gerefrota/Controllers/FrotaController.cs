using Domain.Abstract.Services;
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

        [HttpGet]
        public IActionResult Get() => Ok(_frotaService.Get());
    }
}
