using Domain.Abstract.Services;
using Microsoft.AspNetCore.Mvc;


namespace Gerefrota.Controllers
{
    public class MotoristaController : ControllerBase
    {

        private readonly IMotoristaService _motoristaService;
        public MotoristaController(IMotoristaService motoristaService)
        {
            _motoristaService = motoristaService;
        }

        [HttpGet]
        public IActionResult Get() => Ok(_motoristaService.GetAll());
    }
}
