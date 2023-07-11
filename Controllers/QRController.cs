using Microsoft.AspNetCore.Mvc;

namespace Clase_asp_net.Controllers
{
    public class QRController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [Route("Generar")]
        public IActionResult Generar(string productoid)
        {
            ViewBag.productoid = productoid;
            return View("Index");
        }
    }
}
