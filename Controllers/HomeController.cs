using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using efdemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PC03_Simulacro.Models;

namespace PC03_Simulacro.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AdopcionContext _context;

        public HomeController(ILogger<HomeController> logger, AdopcionContext context )
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var solicitudes = _context.SolicitudesCompra.ToList();
            
            return View(solicitudes);
        }

        public IActionResult SolicitudCompra()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SolicitudCompra(SolicitudCompra sc)
        {
            
            if(ModelState.IsValid){
                _context.Add(sc);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
