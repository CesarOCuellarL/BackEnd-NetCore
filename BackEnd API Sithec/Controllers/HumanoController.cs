using Microsoft.AspNetCore.Mvc;
using webapi_csharp.Modelos;
using webapi_csharp.Repositorios;
using webapi_csharp.DB;
using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;

namespace BackEnd_API_Sithec.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HumanoController : ControllerBase
    {
        private readonly DBConnection context;

        public HumanoController(DBConnection context)
        {
            this.context = context;
        }

        [HttpGet("arrayhumano")]
        public IActionResult Get2()
        {
            RPHumano rpCli = new RPHumano();
            return Ok(rpCli.ObtenerHumanos());
        }

        [HttpGet]
        public IEnumerable<Humano> Get()
        {
            return context.Humano.ToList();
        }

        [HttpGet("{id}")]
        public Humano Get(int id)
        {
            var humano = context.Humano.FirstOrDefault(h => h.Id == id);
            return humano;
        }

        [HttpPost]
        public ActionResult Post([FromBody]Humano humano)
        {
            try
            {
                context.Humano.Add(humano);
                context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody]Humano humano)
        {
            if(humano.Id == id)
            { 
                context.Entry(humano).State = EntityState.Modified;
                context.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }

        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var humano = context.Humano.FirstOrDefault(h => h.Id == id);
            if (humano != null)
            {
                context.Humano.Remove(humano);
                context.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

    }
}