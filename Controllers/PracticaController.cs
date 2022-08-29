using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using webapp.Models;


namespace webapp.Controllers
{
    
    public class PracticaController : Controller
    {
        private readonly ILogger<PracticaController> _logger;

        public PracticaController(ILogger<PracticaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

     [HttpPost]
        public IActionResult Create(Practica objPractica)
        {
            int resultado;
            double Igv;
            int creditos = 3;
            int i;
            

            if(objPractica.Cursos == 1){
                else(100*objPractica.creditos);
            }
            resultado = objPractica.creditos * objPractica.Cursos;
            Igv = resultado * 0.18;
            ViewData["Message"] ="Thanks for submitting your form";
            return View("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}