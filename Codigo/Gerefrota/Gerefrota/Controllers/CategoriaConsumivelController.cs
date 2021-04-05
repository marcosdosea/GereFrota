using Domain.Abstract.Services;
using Microsoft.AspNetCore.Mvc;

namespace Gerefrota.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaConsumivelController : ControllerBase
    {
        private readonly ICategoriaConsumivelService _categoriaConsumivelService;

        public CategoriaConsumivelController(ICategoriaConsumivelService categoriaConsumivelService)
        {
            _categoriaConsumivelService = categoriaConsumivelService;
        }

        [HttpGet]
        public IActionResult Get() => Ok(_categoriaConsumivelService.GetAll());
    }
}
