using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using src.Domain.Models.ServicosVtr;
using src.Respositories;
using System;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace src.Controllers.Vtr
{
    [Route("api/vtr/[controller]")]
    [ApiController]
    public class ServicosController : ControllerBase
    {
        private readonly IServicosVtrRepository _repo;
        private readonly ILogger<ServicosController> _logger;

        public ServicosController(IServicosVtrRepository repo, ILogger<ServicosController> logger)
        {
            _repo = repo;
            _logger = logger;
        }

        // GET: api/<AgendaController>
        // GET: api/<AgendaController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _repo.GetAll();
            return result.Any() ? Ok(result) : StatusCode(204);
        }

        // GET api/<AgendaController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var t = await _repo.GetById(id);
            return t != null ? Ok(t) : NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TabelaServicos value)
        {
            bool result = (bool)await _repo.Save(value);
            return result == true ? Accepted() : StatusCode(500);
        }

        // PUT api/<TanqueController>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] TabelaServicos value)
        {
            bool result = (bool)await _repo.Update(value);
            return result == true ? Accepted() : StatusCode(500);
        }

        // DELETE api/<TanqueController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            bool result = (bool)await _repo.Delete(id);
            return result == true ? Accepted() : StatusCode(500);
        }
    }
}
