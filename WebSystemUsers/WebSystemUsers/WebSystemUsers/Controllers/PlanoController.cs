using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebSystemUsers.Controllers
{
    public class PlanoController : Controller
    {
        public IActionResult Plano()
        {
            return View();
        }
    }
}
