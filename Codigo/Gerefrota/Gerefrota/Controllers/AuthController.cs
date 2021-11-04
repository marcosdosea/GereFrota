using Domain.Abstract.Services;
using Domain.Abstract.Services.Auxs;
using Domain.Models.Auxs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Claims;
using System.Text.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Gerefrota.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly IUsuarioService _usuarioService;
        public AuthController(IAuthService authService, IUsuarioService usuarioService)
        {
            _authService = authService;
            _usuarioService = usuarioService;
        }

        [HttpPost]
        public IActionResult Authenticate([FromBody] UserLogin model)
        {
            // Recupera o usuário
            var user = _usuarioService.GetUsuarioByLoginAndPass(model);

            // Verifica se o usuário existe
            if (user == null)
                return NotFound(new { message = "Usuário ou senha inválidos" });

            // Gera o Token
            var token = _authService.GenerateToken(user);

            // Retorna os dados
            return Ok(token);
        }

        [HttpGet]
        [Route("authenticated")]
        [Authorize(Roles = "USUARIO")]
        public string Authenticated()
        {
            var identity = User.Identity as ClaimsIdentity;

            //User.Claims


            var X = identity.Claims.ElementAt(3).Value;
            return $"{JsonSerializer.Serialize(X)}";
        }
    }
}

