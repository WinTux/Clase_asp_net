using Clase_asp_net.Extra;
using Clase_asp_net.Models;
using Microsoft.AspNetCore.Mvc;

namespace Clase_asp_net.Controllers
{
    public class CarritoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Agregar(string id)
        {
            ProductoModelView productoModelView = new ProductoModelView();
            if (ConversorParaSesion.ConvertirACsharp<List<Item>>(HttpContext.Session, "carrito") == null) { 
                //Crear una lista de items
                // agegar el producto que quiere (parametro que nos llegó) a la lista de items
                // crear una variable "carrito" en la sesión (agregando la lista de items)
            }
            return View();
        }
    }
}
