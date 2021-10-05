﻿using Microsoft.AspNetCore.Mvc;
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
    public class AgendaTanqueController : ControllerBase
    {
        private readonly IVtrRepository<AgendaTanque> _repo;
        private readonly ILogger<AgendaTanqueController> _logger;

        public AgendaTanqueController(IVtrRepository<AgendaTanque> repo, ILogger<AgendaTanqueController> logger)
        {
            _repo = repo;
            _logger = logger;
        }

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

        [HttpGet("agendas/{agendas}")]
        public async Task<IActionResult> GetByAgendas(string agendas)
        {
            string[] lista = agendas.Split("|");
            if (!lista.Any()) return BadRequest(agendas);
            var at = (await _repo.GetAll());
            if (at.Any())
            {                
                var agendasTanque = at.Where(agenda => lista.Contains(agenda.Agenda));
                return agendas != null ? Ok(agendas) : NotFound();
            }
            return at.Any() ? Ok(agendas) : NotFound();
        }

        // POST api/<AgendaController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AgendaTanque value)
        {
            bool result = (bool)await _repo.Save(value);
            return result == true ? Accepted() : StatusCode(500);
        }

        // PUT api/<AgendaController>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] AgendaTanque value)
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
