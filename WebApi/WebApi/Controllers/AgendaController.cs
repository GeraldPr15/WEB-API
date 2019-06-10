using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model;
using Service;

namespace WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AgendaController : Controller
    {
        private readonly IAgendaService _agendaService;
        public AgendaController(IAgendaService agendaService)
        {
            _agendaService = agendaService;
        }
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(
                _agendaService.GetAll()
            );
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(
                _agendaService.Get(id)
            );
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Agenda model)
        {
            return Ok(
                _agendaService.Add(model)
            );
        }

        // PUT api/values/5
        [HttpPut]
        public IActionResult Put([FromBody] Agenda model)
        {
            return Ok(
                _agendaService.Add(model)
            );
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(
                _agendaService.Delete(id)
            );
        }
    }
}
