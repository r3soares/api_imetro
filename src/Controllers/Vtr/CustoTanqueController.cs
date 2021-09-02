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
    public class CustoTanqueController : ControllerBase
    {

        private readonly ILogger<CustoTanqueController> _logger;

        public CustoTanqueController(ILogger<CustoTanqueController> logger)
        {
            _logger = logger;
        }

        // GET: api/<CustoTanqueController>
        [HttpGet]
        public IEnumerable<CustoTanque> Get()
        {
            return null;
        }

        // GET api/<CustoTanqueController>/5
        [HttpGet("{id}")]
        public CustoTanque Get(string id)
        {
            return null;
        }

        // POST api/<CustoTanqueController>
        [HttpPost]
        public void Post([FromBody] CustoTanque value)
        {
        }

        // PUT api/<CustoTanqueController>/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] CustoTanque value)
        {
        }

        // DELETE api/<CustoTanqueController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
        }
    }
}
