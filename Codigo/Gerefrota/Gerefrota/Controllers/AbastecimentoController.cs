using Domain.Abstract.Services;
using Microsoft.AspNetCore.Mvc;

namespace Gerefrota.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AbastecimentoController : ControllerBase
    {
        private readonly IAbastecimentoService _abastecimentoService;
        public AbastecimentoController(IAbastecimentoService abastecimentoService)
        {
            _abastecimentoService = abastecimentoService;
        }

        // GET: api/<AbastecimentoController>
        [HttpGet]
        public IActionResult Get() => Ok(_abastecimentoService.GetAll());

        // GET api/<AbastecimentoController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id) => Ok(_abastecimentoService.Get(x => x.Id == id));
    }
}
