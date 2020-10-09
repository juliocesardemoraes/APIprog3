using System;
using System.Net;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using pacientesPessoas.Models;
using Newtonsoft.Json;



namespace pacientesPessoas.Controllers
{
    public class PacientesController : Controller
    {
        
        private readonly ILogger<PacientesController> logger;

        public PacientesController(ILogger<PacientesController> logger){
            this.logger = logger;
        }
        
       
         
        
        public async Task<string> getPacientes(){
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

// Pass the handler to httpclient(from you are calling api)
            HttpClient client = new HttpClient(clientHandler);  
            string response = await client.GetStringAsync("https://localhost:5000/api/Pacientes");
            Console.WriteLine(response);

            return response;
        }
        public async Task<IActionResult> Index(){
            string list = await getPacientes();
            
            List<Pacientes> m = JsonConvert.DeserializeObject<List<Pacientes>>(list);
            Console.WriteLine(m);
            return View(m);
        }

        public IActionResult Editar(){
            return View();
        }

        public IActionResult Excluir(){
            return View();
        }

        
         [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}