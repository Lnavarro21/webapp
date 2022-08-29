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
        double Igv;
        double res;
        double total;
        int i = 0;
        
        if (objPractica.Matematica)
            i = i + 1;
        if (objPractica.Lenguaje)
            i = i+1;
        if (objPractica.Historia)
            i = i+1;

        res = i * (i * 100);
        Igv = res * 0.18;
        total = res + Igv;
            
        ViewData["Message1"] = "El costo de los cursos es: " + res.ToString();
        ViewData["Message2"] = "IGV: " + Igv.ToString();
        ViewData["Message3"] = "El precio total es: " + total.ToString();
        
        return View("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}