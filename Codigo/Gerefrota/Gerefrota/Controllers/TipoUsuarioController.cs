using Domain.Abstract.Services;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gerefrota.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoUsuarioController : ControllerBase
    {
        private readonly ITipoUsuarioService _tipoUsuarioService;
        public TipoUsuarioController(ITipoUsuarioService tipoUsuarioService)
        {
            _tipoUsuarioService = tipoUsuarioService;
        }

        [HttpGet]
        public IActionResult Get() => Ok(_tipoUsuarioService.GetAll());

        [HttpPost]
        public IActionResult Inserir([FromBody] TipoUsuarioModel tipoUsuario) => Ok(_tipoUsuarioService.Insert(tipoUsuario));
    }
}
