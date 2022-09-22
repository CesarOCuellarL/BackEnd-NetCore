using Microsoft.AspNetCore.Mvc;
using webapi_csharp.Modelos;
using webapi_csharp.Repositorios;

namespace BackEnd_API_Sithec.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HumanoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            RPHumano rpCli = new RPHumano();
            return Ok(rpCli.ObtenerHumanos());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            RPHumano rpCli = new RPHumano();

            var cliRet = rpCli.ObtenerHumano(id);

            if (cliRet == null)
            {
                var nf = NotFound("El Humano " + id.ToString() + " no existe.");
                return nf;
            }

            return Ok(cliRet);
        }

        [HttpPost("agregar")]
        public IActionResult AgregarHumano(Humano nuevoHumano)
        {
            RPHumano rpCli = new RPHumano();
            rpCli.Agregar(nuevoHumano);
            return CreatedAtAction(nameof(AgregarHumano), nuevoHumano);
        }

        [HttpPut("modificar")]
        public IActionResult ModificarHumano(Humano editarHumano)
        {
            RPHumano rpCli = new RPHumano();

            rpCli.Editar(editarHumano);
            return CreatedAtAction(nameof(ModificarHumano), editarHumano);
        }
    }
}