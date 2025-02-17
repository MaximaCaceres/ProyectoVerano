
using Microsoft.Data.SqlClient;
using System.Globalization;
using WebApplication1.Models;

namespace WebApplication1.DAOs
{
    public class AlumnoDAO
    {
        private readonly string cadenaConexion;

        public AlumnoDAO(string cadena)
        {
            cadenaConexion = cadena;
        }
        #region Caso GetAll
        public List<Alumno> GetAll()
        {
            var alumnos = new List<Alumno>();

            var conexion = new SqlConnection(cadenaConexion);
            conexion.Open();

            var query = "SELECT * FROM Alumno";
            using var comando = new SqlCommand(query, conexion);

            var reader = comando.ExecuteReader();
           while (reader.Read())
            {
                alumnos.Add(new Alumno()
                {
                    Id = reader.GetInt32(0),
                    Nombre = reader.GetString(1),
                    LU = reader.GetInt32(2),
                    Nota = reader.GetDouble(3)
                });
            }
           return alumnos;
        }

        public Alumno? GetById(int id)
        {
            Alumno alumno = null;
            using var conexion = new SqlConnection(cadenaConexion);
            conexion.Open();

            var query = "SELECT * FROM Alumno WHERE Id = @Id";
            using var comando = new SqlCommand( query, conexion);
            comando.Parameters.AddWithValue("@Id",id);

            var reader = comando.ExecuteReader();
            if (reader.Read())
            {
                alumno = new Alumno()
                {
                    Id = reader.GetInt32(0),
                    Nombre = reader.GetString(1),
                    LU = reader.GetInt32(2),
                    Nota = reader.GetDouble(3)
                };
            }
            return alumno;
        }
        public Alumno? Insert(Alumno a)
        {
            using var conexion = new SqlConnection(cadenaConexion);
            conexion.Open();

            var query = "INSERT INTO Alumno(Nombre,LU,Nota) OUTPUT INSERTED.ID VALUES (@Nombre,@LU,@Nota)";
            using var comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@Nombre", a.Nombre);
            comando.Parameters.AddWithValue("@LU", a.LU);
            comando.Parameters.AddWithValue("@Nota", a.Nota);

            int id = (int)comando.ExecuteScalar();
            Alumno? a2 = GetById(id);
            return a2;
        }
        public bool UpDate(Alumno a)
        {
            using var conexion = new SqlConnection(cadenaConexion);
            conexion.Open();

            var query = "UPDATE Alumno SET Nombre = @Nombre, LU = @LU,Nota = @Nota WHERE Id = @Id";
            using var comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@Nombre", a.Nombre);
            comando.Parameters.AddWithValue("@LU", a.LU);
            comando.Parameters.AddWithValue("@Nota", a.Nota);

            return true;
        }
        public bool Delete(int id)
        {
            using var conexion = new SqlConnection(cadenaConexion);
            conexion.Open();//abre conexion

            var query = "DELETE  FROM Alumno WHERE Id = @Id";//guardamos la query
            using var comando = new SqlCommand(query, conexion);//obtenemos un comando de ejecucion
            comando.Parameters.AddWithValue("@Id", id);//reemplazamos la variable creada con el valor que le pasamos

            return true;
        }
        #endregion
    }
}
