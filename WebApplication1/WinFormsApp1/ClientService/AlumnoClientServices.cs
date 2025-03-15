using Microsoft.AspNetCore.Mvc.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WebApplication1.Services;
using WinFormsApp1.Models;

namespace WinFormsApp1.ClientService
{
    public class AlumnoClientServices
    {
        async public Task<List<Alumno>> GetAll()
        {
            var alumnos = new List<Alumno>();//HACE LA SOLICITUD.

            string url = "https://localhost:7217/api/Alumno";

            var cliente = new HttpClient();

            var response = await cliente.GetAsync(url);//Se va a buscar un metodo httpGet al alumnoController.

            if (response.IsSuccessStatusCode)//TRATA LA RESPUESTA.
            {
                string json = await response.Content.ReadAsStringAsync();

                alumnos = JsonSerializer.Deserialize<List<Alumno>>(json);
            }

            return alumnos;
        }

        async public Task<Alumno> GetId(int id)
        {
            Alumno a = new Alumno();

            string url = "https://localhost:7217/api/Alumno";

            var cliente = new HttpClient();

            var response = await cliente.GetAsync($"{url}/{id}");

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();

                a = System.Text.Json.JsonSerializer.Deserialize<Alumno>(json);
            }
            return a;
        }
        async public Task<Alumno> DeleteAlumno(int lu)
        {
            Alumno a = new Alumno();

            string url = "https://localhost:7217/api/Alumno";

            var cliente = new HttpClient();

            var response = await cliente.DeleteAsync($"{url}/{lu}");

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();

                a = System.Text.Json.JsonSerializer.Deserialize<Alumno>(json);
            }

            return a;
        }
        async public Task<Alumno> AgregarAlumno(Alumno alu)
        {
            Alumno a = new Alumno();

            string url = "https://localhost:7217/api/Alumno";
            
            var cliente = new HttpClient();
            string json = System.Text.Json.JsonSerializer.Serialize(alu);
            HttpContent conten = new StringContent(json,Encoding.UTF8,"application/json");

            var response = await cliente.PostAsync(url, conten);
            if (response.IsSuccessStatusCode)
            {
                string j = await response.Content.ReadAsStringAsync();
                a = System.Text.Json.JsonSerializer.Deserialize<Alumno>(j);   
            }
            return a ;
        }
        async public Task<Alumno> EditAlumno(Alumno al)
        {
            Alumno a = new Alumno();

            string url = "https://localhost:7217/api/Alumno/";

            var cliente = new HttpClient();
            var json = JsonSerializer.Serialize(al);//
            HttpContent conten = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await cliente.PutAsync(url, conten);

            if (response.IsSuccessStatusCode)
            {
                string j = await response.Content.ReadAsStringAsync();

                a = JsonSerializer.Deserialize<Alumno>(j);
            }

            return a;
        }
    }
}
