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
    public class AgendaTanqueController : ControllerBase
    {
        private readonly IVtrRepository<AgendaTanque> _repo;
        private readonly ILogger<AgendaTanqueController> _logger;

        public AgendaTanqueController(IVtrRepository<AgendaTanque> repo, ILogger<AgendaTanqueController> logger)
        {
            _repo = repo;
            _logger = logger;
        }

        // GET: api/<AgendaController>
        [HttpGet]
        public async Task<IEnumerable<AgendaTanque>> Get()
        {
            return await _repo.GetAll();
        }

        // GET api/<AgendaController>/5
        [HttpGet("{id}")]
        public async Task<AgendaTanque> Get(object id)
        {
            return await _repo.GetById(id);
        }

        // POST api/<AgendaController>
        [HttpPost]
        public async Task Post([FromBody] AgendaTanque value)
        {
            await _repo.Save(value);
        }

        // PUT api/<AgendaController>
        [HttpPut]
        public async Task Put([FromBody] AgendaTanque value)
        {
            await _repo.Update(value);
        }

        // DELETE api/<AgendaController>/5
        [HttpDelete("{id}")]
        public async Task Delete(object id)
        {
            await _repo.Delete(id);
        }
    }
}
