using Domain.Abstract.Services;
using Microsoft.AspNetCore.Mvc;

namespace Gerefrota.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViagemController : ControllerBase
    {
        private readonly IViagemService _viagemService;
        public ViagemController(IViagemService viagemService)
        {
            _viagemService = viagemService;
        }

        [HttpGet]
        public IActionResult Get() => Ok(_viagemService.GetAll());
    }
}
