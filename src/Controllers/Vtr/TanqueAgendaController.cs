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
    public class TanqueAgendaController : ControllerBase
    {
        private readonly IVtrRepository<AgendaDoTanque> _repo;
        private readonly ILogger<TanqueAgendaController> _logger;

        public TanqueAgendaController(IVtrRepository<AgendaDoTanque> repo, ILogger<TanqueAgendaController> logger)
        {
            _repo = repo;
            _logger = logger;
        }

        // GET: api/<TanqueAgendadoController>
        [HttpGet]
        public IEnumerable<AgendaDoTanque> Get()
        {
            return _repo.GetAll();
        }

        // GET api/<TanqueAgendadoController>/5
        [HttpGet("{id}")]
        public AgendaDoTanque Get(object id)
        {
            return _repo.GetById(id);
        }

        // POST api/<TanqueAgendadoController>
        [HttpPost]
        public void Post([FromBody] AgendaDoTanque value)
        {
            _repo.Save(value);
        }

        // PUT api/<TanqueAgendadoController>
        [HttpPut]
        public void Put([FromBody] AgendaDoTanque value)
        {
            _repo.Update(value);
        }

        // DELETE api/<TanqueAgendadoController>/5
        [HttpDelete("{id}")]
        public void Delete(object id)
        {
            _repo.Delete(id);
        }
    }
}
