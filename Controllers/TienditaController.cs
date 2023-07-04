using Clase_asp_net.Models;
using Microsoft.AspNetCore.Mvc;

namespace Clase_asp_net.Controllers
{
    public class TienditaController : Controller
    {
        public IActionResult Index()
        {
            ProductoModelView productoModelView = new ProductoModelView();
            ViewBag.prods = productoModelView.getTodos();
            return View();
        }
    }
}
