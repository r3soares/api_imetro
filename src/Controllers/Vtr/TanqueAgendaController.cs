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
        public async Task<IEnumerable<AgendaDoTanque>> Get()
        {
            return await _repo.GetAll();
        }

        // GET api/<TanqueAgendadoController>/5
        [HttpGet("{id}")]
        public async Task<AgendaDoTanque> Get(object id)
        {
            return await _repo.GetById(id);
        }

        // POST api/<TanqueAgendadoController>
        [HttpPost]
        public async Task Post([FromBody] AgendaDoTanque value)
        {
            await _repo.Save(value);
        }

        // PUT api/<TanqueAgendadoController>
        [HttpPut]
        public async Task Put([FromBody] AgendaDoTanque value)
        {
            await _repo.Update(value);
        }

        // DELETE api/<TanqueAgendadoController>/5
        [HttpDelete("{id}")]
        public async Task Delete(object id)
        {
            await _repo.Delete(id);
        }
    }
}
