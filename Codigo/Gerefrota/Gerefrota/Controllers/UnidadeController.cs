using Domain.Abstract.Services;
using Microsoft.AspNetCore.Mvc;

namespace Gerefrota.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnidadeController : ControllerBase
    {
        private readonly IUnidadeService _unidadeService;
        public UnidadeController(IUnidadeService unidadeService)
        {
            _unidadeService = unidadeService;
        }

        /// <summary>
        /// Obtem por ID. (Exemplo de metodo)
        /// </summary>
        /// <param name="id">Id da busca</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id) => Ok(_unidadeService.Get(id));

        [HttpGet()]
        public IActionResult Get() => Ok(_unidadeService.GetAll());
    }
}
