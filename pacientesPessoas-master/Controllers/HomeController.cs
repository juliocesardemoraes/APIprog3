using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using pacientesPessoas.Models;

namespace pacientesPessoas.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Teste(){
            //criar uma lista de pacientes:
            var listaPacientes = new List<Pacientes>(){
                new Pacientes(1,1,"01/10/2020","Teste1",1),
                new Pacientes(2,2,"02/10/2020","Teste2",2),
                new Pacientes(3,1,"03/10/2020","Teste3",3),
                new Pacientes(4,2,"04/10/2020","Teste4",4),
                new Pacientes(5,1,"05/10/2020","Teste5",5),
            };
            return View(listaPacientes);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
