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
    public class EmpresaController : ControllerBase
    {
        private readonly IVtrRepository<Empresa> _repo;
        private readonly ILogger<EmpresaController> _logger;

        public EmpresaController(IVtrRepository<Empresa> repo, ILogger<EmpresaController> logger)
        {
            _repo = repo;
            _logger = logger;
        }

        // GET: api/<EmpresaController>
        [HttpGet]
        public IEnumerable<Empresa> Get()
        {
            return _repo.GetAll();
        }

        // GET api/<EmpresaController>/5
        [HttpGet("{id}")]
        public Empresa Get(string id)
        {
            return _repo.GetById(id);
        }

        // POST api/<EmpresaController>
        [HttpPost]
        public void Post([FromBody] Empresa value)
        {
            _repo.Save(value);
        }

        // PUT api/<EmpresaController>
        [HttpPut]
        public void Put([FromBody] Empresa value)
        {
            _repo.Update(value);
        }

        // DELETE api/<EmpresaController>/5
        [HttpDelete("{id}")]
        public void Delete(object id)
        {
            _repo.Delete(id);
        }
    }
}
