using Clase_asp_net.Extra;
using Clase_asp_net.Models;
using Microsoft.AspNetCore.Mvc;

namespace Clase_asp_net.Controllers
{
    public class CarritoController : Controller
    {
        public IActionResult Index()
        {
            List<Item> carrito = ConversorParaSesion.ConvertirACsharp<List<Item>>(HttpContext.Session, "carrito");
            ViewBag.carrito = carrito;
            ViewBag.total = carrito.Sum(it => it.producto.precio * it.cantidad);
            // SELECT SUM(p.precio * cantidad) FROM producto p;
            return View();
        }

        public IActionResult Agregar(string id)
        {
            ProductoModelView productoModelView = new ProductoModelView();
            if (ConversorParaSesion.ConvertirACsharp<List<Item>>(HttpContext.Session, "carrito") == null)
            {
                //Crear una lista de items
                List<Item> carrito = new List<Item>();
                // agregar el producto que quiere (parametro que nos llegó) a la lista de items
                carrito.Add(new Item { producto = productoModelView.getProducto(id), cantidad = 1 });
                // crear una variable "carrito" en la sesión (agregando la lista de items)
                ConversorParaSesion.ConvertirAjson(HttpContext.Session, "carrito", carrito);
            }
            else {
                //Cuando sí existe un carrito del usuario
                List<Item> carrito = ConversorParaSesion.ConvertirACsharp<List<Item>>(HttpContext.Session, "carrito");

                int indice = existe(id);
                if(indice != -1)
                {
                    //Caso 1: Ya existe el producto en el carrito
                    carrito[indice].cantidad++;
                }
                else
                {
                    //Caso 2: No existe el proudcto en el carrito
                    carrito.Add(new Item { producto = productoModelView.getProducto(id), cantidad = 1 });
                }
                ConversorParaSesion.ConvertirAjson(HttpContext.Session, "carrito", carrito);
            }
            return RedirectToAction("Index");
        }
        [NonAction]
        private int existe(string id)
        {
            List<Item> carrito = ConversorParaSesion.ConvertirACsharp<List<Item>>(HttpContext.Session, "carrito");
            for (int i = 0; i < carrito.Count; i++)
                if (carrito[i].producto.id.Equals(id))
                    return i;
            return -1;
        }
    }
}
