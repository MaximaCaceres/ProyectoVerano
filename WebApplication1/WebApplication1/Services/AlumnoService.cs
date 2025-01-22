using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class AlumnoService
    {
        private static List<Alumno> alumnos = new List<Alumno>()
        {
            new Alumno(){Nombre="Martincito", Id=001, LU=10, Nota=9},
            new Alumno(){Nombre="Maxima", Id = 002, LU=17771, Nota = 8},
            new Alumno(){Nombre="Harahel", Id = 003, LU=17773, Nota = 8.5}  
        };
        public List<Alumno> MostrarLista()
        {
            return alumnos.OrderBy(o=> o.Nota).ToList();
        }                         //le damos valor de nota a "o".
        public string MostrarCantidad()
        {
            string t = "cantidad alumnos en la lista: ";
            return t + alumnos.Count;
        }
        public Alumno UpDate(Alumno mod)
        {
            var a = BuscarPorId(mod.Id);
            if(a != null)
            {
                a.Nombre = mod.Nombre;
                a.Nota = mod.Nota;
                a.LU = mod.LU;
            }
            return a;
        }
        public Alumno BuscarPorId(int id)
        {
            var alumno = alumnos.Where(a => a.Id == id).FirstOrDefault();//me da la primer coincidencia en la lista de alumnos con ese id
            if (alumno != null)
            {
                return alumno;
            }
            return null;
        }
        public Alumno CrearAlumno(Alumno a)
        {
            alumnos.Add(a);
            return a;
        }
        public Alumno EliminarAlumno(int lu)
        {
            var alumno = alumnos.Where(a => a.LU == lu).FirstOrDefault();
            alumnos.Remove(alumno);
            return alumno;
        }
    }
}
