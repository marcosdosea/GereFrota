using Domain.Abstract.Services;
using Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(UnidadeModel))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(EmptyResult))]
        public IActionResult Get(int id) => Ok(_unidadeService.Get(x => x.Id == id));

        [HttpGet()]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<UnidadeModel>))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(EmptyResult))]
        public IActionResult Get() => Ok(_unidadeService.GetAll());
    }
}
