using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using src.Domain.Models.Vtr;
using src.Respositories;
using System;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace src.Controllers.Vtr
{
    [Route("api/vtr/[controller]")]
    [ApiController]
    public class ResponsavelController : Controller
    {
        private readonly IVtrRepository<Responsavel> _repo;
        private readonly ILogger<ResponsavelController> _logger;

        public ResponsavelController(IVtrRepository<Responsavel> repo, ILogger<ResponsavelController> logger)
        {
            _repo = repo;
            _logger = logger;
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            base.OnActionExecuted(context);
        }

        // GET: api/<EmpresaController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _repo.GetAll();
            return result.Any() ? Ok(result) : StatusCode(204);
        }
        

        //// GET api/<EmpresaController>/5
        //[HttpGet("{nome}")]
        //public async Task<IActionResult> Get(string nome)
        //{
        //    var t = await _repo.GetById(nome);
        //    return t != null ? Ok(t) : NotFound();
        //}

        [HttpGet("novo")]
        public IActionResult GetNovoID()
        {
            return Created("", Responsavel.GetNovoID);
        }

        [HttpGet("nomeParcial/{nome}")]
        public async Task<IActionResult> GetByNomeParcial(string nome)
        {
            nome = nome.Replace("|", "");
            var t = await _repo.GetAll();
            if (t.Any())
            {
                var responsaveis = t.Where(e => e.Nome.StartsWith(nome, StringComparison.OrdinalIgnoreCase));
                return responsaveis != null ? Ok(responsaveis) : NotFound();
            }
            return t.Any() ? Ok(t) : NotFound();
        }

        // POST api/<EmpresaController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Responsavel value)
        {
            bool result = (bool)await _repo.Save(value);
            return result == true ? Accepted() : StatusCode(500);
        }

        // PUT api/<EmpresaController>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] Responsavel value)
        {
            bool result = (bool)await _repo.Update(value);
            return result == true ? Accepted() : StatusCode(500);
        }

        // DELETE api/<EmpresaController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            bool result = (bool)await _repo.Delete(id);
            return result == true ? Accepted() : StatusCode(500);
        }

    }
}
