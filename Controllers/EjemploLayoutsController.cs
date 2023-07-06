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

        //Layouts anidados
        public IActionResult Anidado1()
        {
            return View();
        }
        public IActionResult Anidado2()
        {
            return View();
        }
        public IActionResult Anidado3()
        {
            return View();
        }

        public IActionResult Anidado1Menu1()
        {
            return View();
        }
        public IActionResult Anidado1Menu2()
        {
            return View();
        }

        public IActionResult Anidado2Menu1()
        {
            return View();
        }
        public IActionResult Anidado2Menu2()
        {
            return View();
        }
        public IActionResult Anidado2Menu3()
        {
            return View();
        }
    }
}
