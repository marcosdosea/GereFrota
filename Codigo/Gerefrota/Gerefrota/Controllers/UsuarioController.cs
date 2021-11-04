using Domain.Abstract.Services;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gerefrota.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;
        public UsuarioController(IUsuarioService usuarioService) => _usuarioService = usuarioService;

        [HttpGet]
        public IActionResult Get() => Ok(_usuarioService.GetAll());

        [HttpPost]
        public IActionResult Post([FromBody] UsuarioModel usuario) => Ok(_usuarioService.Insert(usuario));
    }
}
