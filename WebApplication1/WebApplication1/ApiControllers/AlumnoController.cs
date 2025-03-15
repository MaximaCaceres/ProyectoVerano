using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.DAOs.MSSDAOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//Recibe las solicitudes (por ejemplo, desde una interfaz web o una API), coordina las
//operaciones necesarias y devuelve las respuestas.

namespace WebApplication1.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class AlumnoController : ControllerBase
    {
        private readonly AlumnoService Service;
        public AlumnoController(AlumnoService service)
        {
            Service = service;
        }

        // GET: api/<PruebaController>
        [HttpGet]//lo busca
        public async Task<IActionResult> Get()
        {
            var alumnos = await Service.GettAll();
            return Ok(alumnos);
        }

        // GET api/<PruebaController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)//Obtener datos de un recurso.
        {
            return Ok(Service.GetById(id));
        }

        // POST api/<PruebaController>
        [HttpPost]
        public async Task<IActionResult> Pos([FromBody] Alumno nuevo)
        {
            await Service.CrearNuevo(nuevo);
            return Ok(); 
        }
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] Alumno modificado)
        {
            await Service.Actualizar(modificado);
            return Ok(); 
        }

        // DELETE api/<PruebaController>/5
        [HttpDelete("{LU}")]
        public async Task<IActionResult> Delete(int LU)
        {
            var resultado = await Service.Eliminar(LU);
            return Ok(new { resultado });
        }
    }
}
