using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using src.Domain.Models.Vtr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace src.Controllers.Vtr
{
    [Route("api/vtr/[controller]")]
    [ApiController]
    public class TanqueController : ControllerBase
    {
        private readonly ILogger<TanqueController> _logger;

        public TanqueController(ILogger<TanqueController> logger)
        {
            _logger = logger;
        }


        // GET: api/<TanqueController>
        [HttpGet]
        public IEnumerable<Tanque> Get()
        {
            return null;
        }

        // GET api/<TanqueController>/5
        [HttpGet("{id}")]
        public Tanque Get(int id)
        {
            return null;
        }

        // POST api/<TanqueController>
        [HttpPost]
        public void Post([FromBody] Tanque value)
        {
        }

        // PUT api/<TanqueController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Tanque value)
        {
        }

        // DELETE api/<TanqueController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
