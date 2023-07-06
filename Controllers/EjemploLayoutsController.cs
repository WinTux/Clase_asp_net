using Microsoft.AspNetCore.Mvc;

namespace Clase_asp_net.Controllers
{
    public class EjemploLayoutsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Destino1()
        {
            return View();
        }
        public IActionResult Destino2()
        {
            return View();
        }
    }
}
