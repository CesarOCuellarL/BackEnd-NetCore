using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using webapi_csharp.Modelos;
using webapi_csharp.Repositorios;

namespace BackEnd_API_Sithec.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            RPValue rpCli = new RPValue();
            return Ok(rpCli.ObtenerValues());
        }

        [HttpGet("Operaciones")]
        public IActionResult Resultados()
        {
            RPValue rpCli = new RPValue();
            return Ok(rpCli.Operaciones());
        }

        [HttpPost("agregar")]
        public IActionResult AgregarValue(Value nuevoValue)
        {
            RPValue rpCli = new RPValue();
            rpCli.Agregar(nuevoValue);
            return CreatedAtAction(nameof(AgregarValue), nuevoValue);
        }
    }
}
