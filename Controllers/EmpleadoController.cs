using Microsoft.AspNetCore.Mvc;

namespace Clase_asp_net.Controllers
{
    public class EmpleadoController : Controller
    {
        public IActionResult Index()
        {
            // proceso 1
            // proceso 2
            // ¿Cómo pasamos valores del controlador a la vista?
            int carnet = 123;
            ViewBag.ci = carnet;
            ViewBag.nombre = "Pepe Perales";
            ViewBag.casado = false;
            ViewBag.estatura = 1.78;
            ViewBag.fecha_contratacion = DateTime.Now;
            return View();
        }
    }
}
