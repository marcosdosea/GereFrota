using Domain.Abstract.Services;
using Microsoft.AspNetCore.Mvc;

namespace Gerefrota.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VistoriaController : ControllerBase
    {
        private readonly IVistoriaService _vistoriaService;
        public VistoriaController(IVistoriaService vistoriaService)
        {
            _vistoriaService = vistoriaService;
        }

        [HttpGet]
        public IActionResult Get() => Ok(_vistoriaService.GetAll());
    }
}
