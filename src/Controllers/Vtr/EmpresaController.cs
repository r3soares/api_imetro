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
        public IEnumerable<Empresa> Get()
        {
            return _repo.GetAll();
        }

        // GET api/<EmpresaController>/5
        [HttpGet("{cnpj}")]
        public IActionResult Get(string cnpj)
        {
            var e = _repo.GetById(cnpj);
            return e != null ? Ok(e) : NotFound();
        }

        // POST api/<EmpresaController>
        [HttpPost]
        public void Post([FromBody] Empresa value)
        {
            _repo.Save(value);
        }

        // PUT api/<EmpresaController>
        [HttpPut]
        public void Put([FromBody] Empresa value)
        {
            _repo.Update(value);
        }

        // DELETE api/<EmpresaController>/5
        [HttpDelete("{id}")]
        public void Delete(object id)
        {
            _repo.Delete(id);
        }
    }
}
