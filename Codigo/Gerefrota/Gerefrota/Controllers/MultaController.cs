using Domain.Abstract.Services;
using Microsoft.AspNetCore.Mvc;

namespace Gerefrota.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MultaController : ControllerBase
    {
        private readonly IMultaService _multaService;
        public MultaController(IMultaService multaService)
        {
            _multaService = multaService;
        }

        [HttpGet]
        public IActionResult Get() => Ok(_multaService.GetAll());

    }
}
