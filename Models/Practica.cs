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
        
        [Display(Name = "Curso", Prompt = "Cursos")]
        public string? Cursos { get; set; }

        [Display(Name = "Matematica")]
        public bool Matematica { get; set; }
        
        [Display(Name = "Lenguaje")]
        public bool Lenguaje { get; set; }

        [Display(Name = "Historia")]
        public bool Historia { get; set; }

    }
}