using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class AlumnoController : ControllerBase
    {
        static AlumnoService Service = new AlumnoService();
        // GET: api/<PruebaController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Service.MostrarLista());
        }

        // GET api/<PruebaController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)//Obtener datos de un recurso.
        {
            return Ok(Service.BuscarPorId(id));
        }

        // POST api/<PruebaController>
        [HttpPost]
        public IActionResult Pos([FromBody] Alumno nuevo)//POST: Enviar datos al servidor.
        {
            return Ok(Service.CrearAlumno(nuevo));
        }
        [HttpPut]
        public IActionResult Put([FromBody] Alumno modificado)//modificar alumno existente.
        {
            var b = Service.UpDate(modificado);
            if (b != null)
            {
                return Ok(b);
            }
            return BadRequest("No se modifico el alumno");
        }

        // DELETE api/<PruebaController>/5
        [HttpDelete("{LU}")]
        public IActionResult Delete(int LU)
        {
            Alumno a = new Alumno();
            return Ok(new { a = Service.EliminarAlumno(LU) });
        }
    }
}
