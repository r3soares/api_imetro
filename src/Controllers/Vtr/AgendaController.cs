using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using src.Domain.Models.Vtr;
using src.Respositories;
using System;
using System.Collections.Generic;
using System.Globalization;
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
        private readonly CultureInfo dataFormato = CultureInfo.GetCultureInfo("pt-BR");

        public AgendaController(IVtrRepository<Agenda> repo, ILogger<AgendaController> logger)
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
            return result.Any() ? Ok(result) : new EmptyResult();
        }

        // GET api/<AgendaController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var t = await _repo.GetById(id);
            return t != null ? Ok(t) : NotFound();
        }

        [HttpGet("periodo/{periodo}")]
        public async Task<IActionResult> GetByPeriodo(string periodo)
        {
            var t = (await _repo.GetAll());
            if (t.Any())
            {
                var inicioFim = periodo.Split("|");
                bool valido = DateTimeOffset.TryParse(inicioFim[0], out var inicio) &
                DateTimeOffset.TryParse(inicioFim[1], out var fim);
                if (!valido) return BadRequest(periodo);
                var agendas = t.Where(agenda => agenda.D >= inicio.Date && agenda.D <= fim.Date);
                return agendas != null ? Ok(agendas) : NotFound();
            }
            return t.Any() ? Ok(t) : NotFound();
        }

        // POST api/<AgendaController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Agenda value)
        {
            value.D = DateTimeOffset.Parse(value.Data, dataFormato);
            bool result = (bool)await _repo.Save(value);
            return result == true ? Accepted() : StatusCode(500);
        }

        // PUT api/<AgendaController>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] Agenda value)
        {
            value.D = DateTimeOffset.Parse(value.Data, dataFormato);
            bool result = (bool)await _repo.Update(value);
            return result == true ? Accepted() : StatusCode(500);
        }

        // DELETE api/<AgendaController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            bool result = (bool)await _repo.Delete(id);
            return result == true ? Accepted() : StatusCode(500);
        }
    }
}
