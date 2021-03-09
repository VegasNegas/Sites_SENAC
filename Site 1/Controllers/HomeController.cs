using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Atividade_2.Models;
using Microsoft.AspNetCore.Http;

namespace Atividade_2.Controllers
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
            UsuarioBD.TestarConexao();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult CadastrarViagem(){
            if(HttpContext.Session.GetInt32("IdUsuario") == null)
                return RedirectToAction("Login","Usuario");
            
            return View();
        }
        
        public IActionResult Lista(){
            PacotesTuristicoBD p_bd = new PacotesTuristicoBD();
            List<PacotesTuristicos> lista = p_bd.Listar();

            return View(lista);
        }
        
         

        [HttpPost]
        public IActionResult CadastrarViagem(PacotesTuristicos pacote){
            PacotesTuristicoBD p_bd = new PacotesTuristicoBD();
            int? v1 = HttpContext.Session.GetInt32("IdUsuario");
            
            p_bd.Cadastrar(pacote, v1.GetValueOrDefault());
            return RedirectToAction("Lista");
        }

        public IActionResult Editar(int Id){
            PacotesTuristicoBD p_bd = new PacotesTuristicoBD();
            PacotesTuristicos pacote = p_bd.BuscarId(Id);
            
            return View();
        }  

        [HttpPost]

        public IActionResult Editar(PacotesTuristicos pacote){
            PacotesTuristicoBD p_bd = new PacotesTuristicoBD();
            int? v1 = HttpContext.Session.GetInt32("IdUsuario");
            
            p_bd.Editar(pacote, v1.GetValueOrDefault());
            return RedirectToAction("Lista");
        }

        public IActionResult Remover(int Id){
            PacotesTuristicoBD p_bd = new PacotesTuristicoBD();
            p_bd.Remover(Id);

            return RedirectToAction("Lista");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
