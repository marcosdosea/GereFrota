using Domain.Abstract.Services;
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
    }
}
