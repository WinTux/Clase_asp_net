using Clase_asp_net.Extra;
using Microsoft.AspNetCore.Mvc;

namespace Clase_asp_net.Controllers
{
    public class ProductoController : Controller
    {
        private DDBBContext ddbb;
        public ProductoController(DDBBContext ddbb)
        {
            this.ddbb = ddbb;
        }
        public IActionResult Index()
        {
            ViewBag.productos = ddbb.Productos.ToList();
            return View();
        }
    }
}
