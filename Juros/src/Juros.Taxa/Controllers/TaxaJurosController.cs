using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Juros.Taxa.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaxaJurosController : ControllerBase
    {
        const double TAXA = 0.01;

        public TaxaJurosController() { }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(TAXA);
        }
    }
}
