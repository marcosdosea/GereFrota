﻿using Domain.Abstract.Services;
using Microsoft.AspNetCore.Mvc;


namespace Gerefrota.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsumivelVeicularController : ControllerBase
    {
        private readonly IConsumivelVeicularService _consumivelVeicularService;
        public ConsumivelVeicularController(IConsumivelVeicularService consumivelVeicularService)
        {
            _consumivelVeicularService = consumivelVeicularService;
        }

        // GET: api/<ConsumivelVeicularController>
        [HttpGet]
        public IActionResult Get() => Ok(_consumivelVeicularService.GetAll());

        // GET api/<ConsumivelVeicularController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ConsumivelVeicularController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ConsumivelVeicularController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ConsumivelVeicularController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
