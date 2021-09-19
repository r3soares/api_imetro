using Microsoft.AspNetCore.Http;
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
        public async Task<IEnumerable<Tanque>> Get()
        {
            return await _repo.GetAll();
        }

        // GET api/<TanqueController>/5
        [HttpGet("{inmetro}")]
        public async Task<IActionResult> Get(string id)
        {
            var t = await _repo.GetById(id);
            return t != null ? Ok(t) : NotFound();
        }

        [HttpGet("placa/{placa}")]
        public async Task<IActionResult> GetByPlaca(string placa)
        {
            var t = (await _repo.GetAll()).FirstOrDefault(tanque => tanque.Placa.Equals(placa));
            return t != null ? Ok(t) : NotFound();
        }

        // POST api/<TanqueController>
        [HttpPost]
        public async Task Post([FromBody] Tanque value)
        {
            await _repo.Save(value);
        }

        // PUT api/<TanqueController>
        [HttpPut]
        public async Task Put([FromBody] Tanque value)
        {
            await _repo.Update(value);
        }

        // DELETE api/<TanqueController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _repo.Delete(id);
        }
    }
}
