using Domain.Abstract.Services;
using Domain.Models.Auxs;
using Gerefrota.Extensions.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Claims;

namespace Gerefrota.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ManutencaoController : ControllerBase
    {
        private readonly IVeiculoService _veiculoService;
        private readonly IFrotaService _frotaService;
        private readonly IUnidadeService _unidadeService;
        private UserAndTypeModel _usuarioLogado;
        public ManutencaoController(IVeiculoService veiculoService, IFrotaService frotaService, IUnidadeService unidadeService)
            => (_veiculoService, _frotaService, _unidadeService) = (veiculoService, frotaService, unidadeService);

        [HttpGet]
        public IActionResult Get()
        {
            _usuarioLogado = ((ClaimsIdentity)User.Identity).GetIdentityUser();

            var frotas = _frotaService.ObterTodasAsFrotasPorUnidade(_usuarioLogado.Usuario.IdUnidade);
            var unidade = _unidadeService.Get(u => u.Id == _usuarioLogado.Usuario.IdUnidade);
            var solicitacoes = frotas.Select(f => _veiculoService.GetAllVeiculosAndSolicitacao(f.Id));
            return Ok(new { solicitacoes, unidade });
        }
    }
}
