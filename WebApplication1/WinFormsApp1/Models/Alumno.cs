using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public class Alumno
    {
        [JsonPropertyName("nombre")]
        public string Nombre { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("lu")]
        public int LU { get; set; }

        [JsonPropertyName("nota")]
        public double Nota { get; set; }

        public Alumno(string n, int id, int lu, double not)
        {
            Nombre = n;
            Id = id;
            LU = lu;
            Nota = not;
        }
        public Alumno()
        {

        }
    }
}
