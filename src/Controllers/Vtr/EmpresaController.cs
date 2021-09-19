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
        public async Task<IEnumerable<Empresa>> Get()
        {
            return await _repo.GetAll();
        }

        // GET api/<EmpresaController>/5
        [HttpGet("{cnpj}")]
        public async Task<IActionResult> Get(string cnpj)
        {
            var e = await _repo.GetById(cnpj);
            return e != null ? Ok(e) : NotFound();
        }

        // POST api/<EmpresaController>
        [HttpPost]
        public async Task Post([FromBody] Empresa value)
        {
            await _repo.Save(value);
        }

        // PUT api/<EmpresaController>
        [HttpPut]
        public async Task Put([FromBody] Empresa value)
        {
            await _repo.Update(value);
        }

        // DELETE api/<EmpresaController>/5
        [HttpDelete("{id}")]
        public async Task Delete(object id)
        {
            await _repo.Delete(id);
        }
    }
}
