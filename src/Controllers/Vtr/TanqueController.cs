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
    public class TanqueController : Controller
    {
        private readonly ILogger<TanqueController> _logger;
        private readonly IVtrRepository<Tanque> _repo;

        public TanqueController(IVtrRepository<Tanque> repo, ILogger<TanqueController> logger)
        {
            _repo = repo;
            _logger = logger;
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            base.OnActionExecuted(context);
        }


        // GET: api/<TanqueController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _repo.GetAll();
            return result.Any() ? Ok(result) : new EmptyResult();
        }

        // GET api/<TanqueController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var t = await _repo.GetById(id);
            return t != null ? Ok(t) : NotFound();
        }

        [HttpGet("placa/{placa}")]
        public async Task<IActionResult> GetByPlaca(string placa)
        {
            var t = (await _repo.GetAll());
            if(t.Any())
            {
                var tanque = t.FirstOrDefault(tanque => tanque.Placa.Equals(placa));
                return tanque != null ? Ok(tanque) : NotFound();
            }
            return t.Any() ? Ok(t) : NotFound();
        }

        [HttpGet("proprietario/{cnpj}")]
        public async Task<IActionResult> GetByProprietario(string cnpj)
        {
            var t = await _repo.GetAll();
            if(t.Any())
            {
                t = t.Where(tanque => tanque.Proprietario != null && tanque.Proprietario.Equals(cnpj));
            }
            return t.Any() ? Ok(t) : NotFound();
        }

        // POST api/<TanqueController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Tanque value)
        {
            bool result = (bool)await _repo.Save(value);
            return result == true ? Accepted() : StatusCode(500);
        }

        // PUT api/<TanqueController>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] Tanque value)
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
