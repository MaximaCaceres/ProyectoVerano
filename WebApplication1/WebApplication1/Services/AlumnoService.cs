using WebApplication1.DAOs;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class AlumnoService
    {
        string cadena = "workstation id=BaseMaxima.mssql.somee.com;packet size=4096;user id=Maxima1428_SQLLogin_1;pwd=si8gmykxal;data source=BaseMaxima.mssql.somee.com;persist security info=False;initial catalog=BaseMaxima;TrustServerCertificate=True";
        AlumnoDAO alumnoDAO;
        public AlumnoService()
        {
            alumnoDAO = new AlumnoDAO(cadena);
        }
        #region Sin persistencia
        private static List<Alumno> alumnos = new List<Alumno>()
        {
            new Alumno(){Nombre="Martincito", Id=001, LU=10, Nota=9},
            new Alumno(){Nombre="Maxima", Id = 002, LU=17771, Nota = 8},
            new Alumno(){Nombre="Harahel", Id = 003, LU=17773, Nota = 8.5}  
        };
        public List<Alumno> MostrarLista()
        {
            return alumnoDAO.GetAll();
        }                         //le damos valor de nota a "o".
        public string MostrarCantidad()
        {
            string t = "cantidad alumnos en la lista: ";
            return t + alumnos.Count;
        }
        public bool UpDate(Alumno mod)
        {
            return alumnoDAO.UpDate(mod);
        }
        public Alumno? BuscarPorId(int id)
        {
            return alumnoDAO.GetById(id);
        }
        public Alumno? CrearAlumno(Alumno a)
        {
            return alumnoDAO.Insert(a);
        }
        public bool EliminarAlumno(int id)
        {
            return alumnoDAO.Delete(id);
        }
    }
    #endregion
}
