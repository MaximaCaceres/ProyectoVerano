﻿using WebApplication1.Services;
using WebApplication1.ApiControllers;

namespace WebApplication1.Models
{
    //Es el punto de partida de los datos
    public class Alumno
    {
        public string Nombre {  get; set; }
        public int Id {  get; set; }
        public int LU {  get; set; }
        public double Nota {  get; set; }

    }
}
