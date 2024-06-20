using Microsoft.AspNetCore.Mvc;
using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces;
using System;
using System.Threading.Tasks;

namespace Fretefy.Test.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegiaoController : ControllerBase
    {
        private readonly IRegiaoService _regiaoService;

        public RegiaoController(IRegiaoService regiaoService)
        {
            _regiaoService = regiaoService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var regioes = _regiaoService.List();
            return Ok(regioes);
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var regiao = _regiaoService.Get(id);
            if (regiao == null)
            {
                return NotFound();
            }
            return Ok(regiao);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Regiao regiao)
        {
            await _regiaoService.AddAsync(regiao);
            return CreatedAtAction(nameof(Get), new { id = regiao.Id }, regiao);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] Regiao regiao)
        {
            if (id != regiao.Id)
            {
                return BadRequest();
            }

            await _regiaoService.UpdateAsync(regiao);
            return NoContent();
        }
    }
}
