using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TiendaIdeasElArca.Models;

namespace TiendaIdeasElArca.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        ProductosBL _bl = new ProductosBL();
        public ActionResult Index()
        {
            ViewBag.ListaProductos = _bl.ConsultarProductos().ToList();

            return View();
        }
        public ActionResult Agregar()
        {
            return View();
        }
        public ActionResult Agregar([Bind] Producto producto)
        {
            _bl.CrearProducto(producto);
            return RedirectToAction("Index");
        }
        public IActionResult Privacy()
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
