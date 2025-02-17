using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.ViewControllers
{
    public class AlumnoController : Controller
    {
        // GET: AlumnoController
        static AlumnoService servicio = new AlumnoService();
        public ActionResult Index()
        {
            return View(servicio.MostrarLista());
        }

        /*/ GET: AlumnoController/Details/5 
        public ActionResult Details(int id)
        {
            return View();
        }*/

        // GET: AlumnoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AlumnoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Alumno nuevo)
        {
            try
            {
                servicio.CrearAlumno(nuevo);
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
            return View(servicio.BuscarPorId(id));
        }

        // POST: AlumnoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Alumno nuevo)
        {
            try
            {
                servicio.UpDate(nuevo);
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
            
            return View(servicio.EliminarAlumno(lu));
        }

        // POST: AlumnoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int lu, Alumno eliminado)
        {
            try
            {
                servicio.EliminarAlumno(lu);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        } 
    }
}
