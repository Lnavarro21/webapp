using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace webapp.Models
{
    public class Practica
    {
         [Display(Name = "Datos del Alumno",Prompt = "Ingresar su primer Nombre y su primer Apellido")]
        public string? Nombre {get; set; }
        
        public int Cursos {get; set; }

    }
}