using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using src.Respositories;
using System;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace src.Controllers.Vtr
{
    [Route("api/sgi/[controller]")]
    [ApiController]
    public class MunicipioController : ControllerBase
    {
        private readonly IMunicipiosRepository _repo;
        private readonly ILogger<MunicipioController> _logger;
        private readonly CultureInfo cultura = CultureInfo.InvariantCulture;

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
            return result.Any() ? Ok(result) : StatusCode(204);
        }

        // GET api/<AgendaController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var t = await _repo.GetById(id);
            return t != null ? Ok(t) : NotFound();
        }

        [HttpGet("nome/{nome}")]
        public async Task<IActionResult> GetByNome(string nome)
        {
            nome = nome.Replace("|", "");
            var t = await _repo.GetAll();
            if (t.Any())
            {
                var cidades = t.Where(m => m.NoMunicipio.StartsWith(nome, StringComparison.OrdinalIgnoreCase));
                return cidades != null ? Ok(cidades) : NotFound();
            }
            return t.Any() ? Ok(t) : NotFound();
        }
    }
}
