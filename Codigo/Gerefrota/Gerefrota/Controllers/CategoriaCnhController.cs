using Domain.Abstract.Services;
using Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Gerefrota.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaCnhController : ControllerBase
    {
        private readonly ICategoriaCnhService _cnhService;
        public CategoriaCnhController(ICategoriaCnhService cnhService)
        {
            _cnhService = cnhService;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(CategoriaCnhModel))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(EmptyResult))]
        public IActionResult Post([FromBody] CategoriaCnhModel cnh) => Ok(_cnhService.Insert(cnh));
    }
}
