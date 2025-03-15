using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Controllers;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.ViewControllers
{
    public class AlumnoController : Controller
    {

        private readonly ILogger<HomeController> _logger;

        private readonly AlumnoService servicio;

        public AlumnoController(ILogger<HomeController> logger, AlumnoService alumnoService)
        {
            _logger = logger;
            servicio = alumnoService;
        }

        public async Task<ActionResult>Index()
        {
            var alumno = await servicio.GettAll();
            return View(alumno);
        }

        //GET: AlumnoController/Details/5 
        public async Task<ActionResult>Details(int id)
        {
            var alumno = await servicio.GetById(id);
            return View(alumno);
        }

        // GET: AlumnoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AlumnoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Alumno nuevo)
        {
            try
            {
                await servicio.CrearNuevo(nuevo);
                return RedirectToAction(nameof(Index));

            }
            catch
            {

                return View();
            }
        }

        // GET: AlumnoController/Edit/5
        public ActionResult Edit(int id)
        {
            
            return View();
        }

        // POST: AlumnoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Alumno nuevo)
        {
            try
            {
                await servicio.Actualizar(nuevo);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        
        // GET: AlumnoController/Delete/5
        public ActionResult Delete(int lu)
        {
            
            return View();
        }

        // POST: AlumnoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int lu, Alumno eliminado)
        {
            try
            {
                await servicio.Eliminar(lu);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        } 
    }
}
