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
    public class TanqueAgendadoController : ControllerBase
    {

        private readonly ILogger<TanqueAgendadoController> _logger;

        public TanqueAgendadoController(ILogger<TanqueAgendadoController> logger)
        {
            _logger = logger;
        }

        // GET: api/<TanqueAgendadoController>
        [HttpGet]
        public IEnumerable<AgendaTanque> Get()
        {
            return null;
        }

        // GET api/<TanqueAgendadoController>/5
        [HttpGet("{id}")]
        public string Get(string id)
        {
            return "value";
        }

        // POST api/<TanqueAgendadoController>
        [HttpPost]
        public void Post([FromBody] AgendaTanque value)
        {
        }

        // PUT api/<TanqueAgendadoController>/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] AgendaTanque value)
        {
        }

        // DELETE api/<TanqueAgendadoController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
        }
    }
}
