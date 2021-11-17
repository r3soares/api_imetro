using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
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
    public class EmpresaController : Controller
    {
        private readonly IVtrRepository<Empresa> _repo;
        private readonly ILogger<EmpresaController> _logger;

        public EmpresaController(IVtrRepository<Empresa> repo, ILogger<EmpresaController> logger)
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
            return result.Any() ? Ok(result) : new EmptyResult();
        }

        // GET api/<EmpresaController>/5
        [HttpGet("{cnpj}")]
        public async Task<IActionResult> Get(string cnpj)
        {
            var t = await _repo.GetById(cnpj);
            return t != null ? Ok(t) : NotFound();
        }

        [HttpGet("nome/{nome}")]
        public async Task<IActionResult> GetByNome(string nome)
        {
            nome = nome.Replace("|", "");
            var t = await _repo.GetAll();
            if (t.Any())
            {
                var empresas = t.Where(e => e.Nome.StartsWith(nome, StringComparison.OrdinalIgnoreCase));
                return empresas != null ? Ok(empresas) : NotFound();
            }
            return t.Any() ? Ok(t) : NotFound();
        }

        [HttpGet("cnpjParcial/{cnpj}")]
        public async Task<IActionResult> GetByCnpjParcial(string cnpj)
        {
            var t = await _repo.GetAll();
            if (t.Any())
            {
                var empresas = t.Where(e => e.Cnpj.StartsWith(cnpj, StringComparison.OrdinalIgnoreCase));
                return empresas != null ? Ok(empresas) : NotFound();
            }
            return t.Any() ? Ok(t) : NotFound();
        }

        // POST api/<EmpresaController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Empresa value)
        {
            bool result = (bool)await _repo.Save(value);
            return result == true ? Accepted() : StatusCode(500);
        }

        // PUT api/<EmpresaController>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] Empresa value)
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
