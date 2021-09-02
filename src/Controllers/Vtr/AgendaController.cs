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
    public class AgendaController : ControllerBase
    {

        private readonly ILogger<AgendaController> _logger;

        public AgendaController(ILogger<AgendaController> logger)
        {
            _logger = logger;
        }

        // GET: api/<AgendaController>
        [HttpGet]
        public IEnumerable<Agenda> Get()
        {
            return null;
        }

        // GET api/<AgendaController>/5
        [HttpGet("{id}")]
        public Agenda Get(int id)
        {
            return null;
        }

        // POST api/<AgendaController>
        [HttpPost]
        public void Post([FromBody] Agenda value)
        {
        }

        // PUT api/<AgendaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Agenda value)
        {
        }

        // DELETE api/<AgendaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
