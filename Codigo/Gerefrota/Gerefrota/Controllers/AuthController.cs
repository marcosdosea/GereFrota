using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Abstract.Services;
using Domain.Abstract.Services.Aux;
using Domain.Models.Aux;
using Microsoft.AspNetCore.Mvc;

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
        [Route("login")]
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
    }
}

