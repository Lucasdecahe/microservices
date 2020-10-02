using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Juros.Calculo.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Juros.Calculo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculaJurosController : ControllerBase
    {
        private readonly IRepository _repository;

        public CalculaJurosController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync([Required]decimal valorInicial, [Required]int meses)
        {
            var taxa = await _repository.GetTaxaAsync();

            if (taxa == 0)
                return BadRequest("Sem taxa de juros definida");

            var valorFinal = Math.Truncate(100 * (valorInicial * (decimal)Math.Pow((1 + taxa), meses))) / 100;

            return Ok($"{valorFinal:N2}");
        }
    }
}
