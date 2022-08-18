using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebSystemUsers.Models;

namespace WebSystemUsers.Controllers
{
    public class SobreController : Controller
    {
        private readonly ILogger<SobreController> _logger;

        public SobreController(ILogger<SobreController> logger)
        {
            _logger = logger;
        }


        public IActionResult Sobre()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
