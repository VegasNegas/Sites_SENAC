using Atividade_2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Atividade_2.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Login(){
            
            return View();
        }

        [HttpPost]
        public IActionResult Login(Usuario usuario){
            UsuarioBD UsuarioBanco = new UsuarioBD();
            Usuario UsuarioEncontrado = UsuarioBanco.FazerLogin(usuario);
            
            if(UsuarioEncontrado != null){
                HttpContext.Session.SetInt32("IdUsuario", UsuarioEncontrado.Id);
                HttpContext.Session.SetString("NomeUsuario", UsuarioEncontrado.Nome);
                return RedirectToAction("Index", "Home");
            }
            else{
                ViewBag.Mensagem = "Falha no Login";
                return View();
            }

        }
    
        public IActionResult Logout(){
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }

}