using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using src.Domain.Models.Vtr;
using src.Respositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace src.Controllers.Vtr
{
    [Route("api/vtr/[controller]")]
    [ApiController]
    public class TanqueAgendadoController : ControllerBase
    {
        private readonly IVtrRepository<TanqueAgendado> _repo;
        private readonly ILogger<TanqueAgendadoController> _logger;

        public TanqueAgendadoController(IVtrRepository<TanqueAgendado> repo, ILogger<TanqueAgendadoController> logger)
        {
            _repo = repo;
            _logger = logger;
        }

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

        [HttpGet("pendentes")]
        public async Task<IActionResult> GetPendentes()
        {
            var t = await _repo.GetAll();
            if (t.Any())
            {
                var pendentes = t.Where(tAgendado => tAgendado.StatusConfirmacao == 0);
                return pendentes != null ? Ok(pendentes) : NotFound();
            }
            return t.Any() ? Ok(t) : NotFound();
        }

        [HttpPost("lista")]
        public async Task<IActionResult> GetFromList([FromBody] List<string> ids)
        {
            if (!ids.Any()) return BadRequest(ids);
            var at = (await _repo.GetAll());
            if (at.Any())
            {
                List<TanqueAgendado> lista = new(ids.Count);
                foreach (var id in ids)
                {
                    TanqueAgendado ta = await _repo.GetById(id);
                    if (ta != null)
                    {
                        lista.Add(ta);
                        continue;
                    }
                    return BadRequest(id);
                }
                //var atFiltrado = at.Where(agendado => ids.Contains(agendado.Id));
                return Ok(lista);
            }
            return NotFound();
        }


        [HttpPost("agendas")]
        public async Task<IActionResult> GetByAgendas([FromBody] List<string> agendas)
        {
            if (!agendas.Any()) return BadRequest(agendas);
            var at = await _repo.GetAll();
            if (at.Any())
            {
                List<TanqueAgendado> lista = new(agendas.Count);
                foreach (var a in agendas)
                {
                    TanqueAgendado ta = at.FirstOrDefault(t => t.Agenda.Equals(a));
                    if (ta != null)
                    {
                        lista.Add(ta);
                        continue;
                    }
                    return BadRequest(a);
                }
                return Ok(lista);
            }
            return NotFound();
        }

        // POST api/<AgendaController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TanqueAgendado value)
        {
            bool result = (bool)await _repo.Save(value);
            return result == true ? Accepted() : StatusCode(500);
        }

        // PUT api/<AgendaController>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] TanqueAgendado value)
        {
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
