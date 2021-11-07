using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using src.Domain.Models.Municipios;
using src.Respositories;
using System;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace src.Controllers.Vtr
{
    [Route("api/[controller]")]
    [ApiController]
    public class MunicipioController : ControllerBase
    {
        private readonly IMunicipiosRepository _repo;
        private readonly ILogger<MunicipioController> _logger;

        public MunicipioController(IMunicipiosRepository repo, ILogger<MunicipioController> logger)
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

        [HttpGet("nome/{nome}")]
        public async Task<IActionResult> GetByNome(string nome)
        {
            var t = (await _repo.GetAll());
            if (t.Any())
            {
                var cidades = t.Where(m => m.NoMunicipio.StartsWith(nome,StringComparison.OrdinalIgnoreCase));
                return cidades != null ? Ok(cidades) : NotFound();
            }
            return t.Any() ? Ok(t) : NotFound();
        }
    }
}
