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
    public class EmpresaController : ControllerBase
    {

        private readonly ILogger<EmpresaController> _logger;

        public EmpresaController(ILogger<EmpresaController> logger)
        {
            _logger = logger;
        }

        // GET: api/<EmpresaController>
        [HttpGet]
        public IEnumerable<Empresa> Get()
        {
            return null;
        }

        // GET api/<EmpresaController>/5
        [HttpGet("{id}")]
        public Empresa Get(int id)
        {
            return null;
        }

        // POST api/<EmpresaController>
        [HttpPost]
        public void Post([FromBody] Empresa value)
        {
        }

        // PUT api/<EmpresaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Empresa value)
        {
        }

        // DELETE api/<EmpresaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
