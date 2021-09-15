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
    public class TanqueController : ControllerBase
    {
        private readonly ILogger<TanqueController> _logger;
        private readonly IVtrRepository<Tanque> _repo;

        public TanqueController(IVtrRepository<Tanque> repo, ILogger<TanqueController> logger)
        {
            _repo = repo;
            _logger = logger;
        }


        // GET: api/<TanqueController>
        [HttpGet]
        public IEnumerable<Tanque> Get()
        {
            return _repo.GetAll();
        }

        // GET api/<TanqueController>/5
        [HttpGet("{id}")]
        public Tanque Get(int id)
        {
            return _repo.GetById(id);
        }

        // POST api/<TanqueController>
        [HttpPost]
        public void Post([FromBody] Tanque value)
        {
            value.DataRegistro = DateTimeOffset.Now;
            _repo.Save(value);
        }

        // PUT api/<TanqueController>
        [HttpPut]
        public void Put([FromBody] Tanque value)
        {
            value.DataUltimaAlteracao = DateTimeOffset.Now;
            _repo.Update(value);
        }

        // DELETE api/<TanqueController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repo.Delete(id);
        }
    }
}
