using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebSystemUsers.Models;
using Microsoft.EntityFrameworkCore;
using WebSystemUsers.Connection;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebSystemUsers.Controllers
{
    public class TipoController : Controller
    {
        private readonly  BancoContext db;

        public TipoController(BancoContext conect)
        {
            db = conect;
        }

        public ActionResult ConsultaTipo()

        {
          
            
            return View(db.tipodb.ToList());
        }

        [HttpGet]
        public ActionResult CadastroTipo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CadastroTipo(TipoModel tipomodref)
        {
            
            db.tipodb.Add(tipomodref);
            db.SaveChanges();
            return RedirectToAction("ConsultaTipo");
        }

        [HttpGet]
        public ActionResult EditarTipo(int id)
        {
            var model = db.userdb.Find(id);


            return View(model);
        }



        [HttpPost]
        public ActionResult EditarTipo(TipoModel tip)
        {

            db.Entry(tip).State = EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction("ConsultaTipo");
        }


        public ActionResult DeletarTipo(int Id)
        {
            var user = db.userdb.Find(Id);
            db.userdb.Remove(user);
            db.SaveChanges();
            return RedirectToAction("ConsultaUsuario");
        }

        //[HttpGet]
        //public ActionResult _BuscasUsuario(int? idcliente, string idcpf, DateTime? dataNasc)
        //{
        //    {
        //        // consulta linq
        //        List<UsuarioModel> usuarios = (from u in db.userdb
        //                                      where (idcliente != null ? u.id == idcliente : 0 == 0)
        //                                      && (idcpf != null ? u.cpf == idcpf : 0 == 0)
        //                                      && (dataNasc != null ? u.dataNascimento == dataNasc : 0 == 0)
        //                                      select u
        //                       ).ToList();

        //        return PartialView(usuarios);
        //    }
        //}
    }
}

    

