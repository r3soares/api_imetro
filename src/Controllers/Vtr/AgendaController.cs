using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using src.Domain.Models.Vtr;
using src.Respositories;
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
        private readonly IVtrRepository<Agenda> _repo;
        private readonly ILogger<AgendaController> _logger;

        public AgendaController(IVtrRepository<Agenda> repo, ILogger<AgendaController> logger)
        {
            _repo = repo;
            _logger = logger;
        }

        // GET: api/<AgendaController>
        [HttpGet]
        public IEnumerable<Agenda> Get()
        {
            return _repo.GetAll();
        }

        // GET api/<AgendaController>/5
        [HttpGet("{id}")]
        public Agenda Get(object id)
        {
            return _repo.GetById(id);
        }

        // POST api/<AgendaController>
        [HttpPost]
        public void Post([FromBody] Agenda value)
        {
            _repo.Save(value);
        }

        // PUT api/<AgendaController>
        [HttpPut]
        public void Put([FromBody] Agenda value)
        {
            _repo.Update(value);
        }

        // DELETE api/<AgendaController>/5
        [HttpDelete("{id}")]
        public void Delete(object id)
        {
            _repo.Delete(id);
        }
    }
}
