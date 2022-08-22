using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using WebSystemUsers.Connection;
using WebSystemUsers.Models;

namespace WebSystemUsers.Controllers
{
    public class CadastroController : Controller
    {
        private readonly BancoContext db;

        public CadastroController(BancoContext conect)
        {
            db = conect;
        }

        
        public ActionResult ConsultaUsuario()

        {

            return View(db.userdb.ToList());
        }

        [HttpGet]
        [Authorize(Roles = "root,admin")]
        public ActionResult CadastroUsuario()
        {
            ViewBag.tiposid = new SelectList(db.tipodb.ToList(), "id", "nomeTipo");
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "root,admin")]
        public ActionResult CadastroUsuario(UsuarioModel usuariomodref)
        {
            usuariomodref.status = "Ativo";
            db.userdb.Add(usuariomodref);
            db.SaveChanges();
            return RedirectToAction("ConsultaUsuario");
        }

        [HttpGet]
        [Authorize(Roles = "root,admin")]
        public ActionResult EditarUsuario(int id)
        {

            ViewBag.tiposid = new SelectList(db.tipodb.ToList(), "id", "nomeTipo");
            List<SelectListItem> items = new List<SelectListItem>();

            items.Add(new SelectListItem { Text = "Ativo", Value = "0" });

            items.Add(new SelectListItem { Text = "Desabilitado", Value = "1" });



            ViewBag.status = items;
            var model = db.userdb.Find(id);


            return View(model);
        }



        [HttpPost]
        [Authorize(Roles = "root,admin")]
        public ActionResult EditarUsuario(UsuarioModel user)
        {
            if (user.status == "0")
            {
                user.status = "Ativo";
            }
            else
            {
                user.status = "Desabilitado";
            }
            db.Entry(user).State = EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction("ConsultaUsuario");
        }

        [HttpDelete]
        [Authorize(Roles = "root")]
        public ActionResult DeletarUsuario(int Id)
        {
            var user = db.userdb.Find(Id);
            db.userdb.Remove(user);
            db.SaveChanges();
            return RedirectToAction("ConsultaUsuario");
        }

        
    }
}



