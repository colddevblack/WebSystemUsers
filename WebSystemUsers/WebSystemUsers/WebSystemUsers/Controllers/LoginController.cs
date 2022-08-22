using Microsoft.AspNetCore.Mvc;
using WebSystemUsers.Connection;
using WebSystemUsers.Models;

namespace WebSystemUsers.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {

            return RedirectToAction("Dashboard_1", "Dashboards");

        }

        //[HttpPost]
        //public IActionResult Index(UsuarioModel usuario)
        //{
        //    if (usuario != null)
        //    {
        //        return RedirectToAction("Dashboard_1", "Dashboards");

        //    }

        //    return View("Usuario Não encontrado");  
            

        //}
    }
}
