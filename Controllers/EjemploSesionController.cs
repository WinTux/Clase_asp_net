using Clase_asp_net.Extra;
using Clase_asp_net.Models;
using Microsoft.AspNetCore.Mvc;

namespace Clase_asp_net.Controllers
{
    public class EjemploSesionController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.SetInt32("edad", 21);
            HttpContext.Session.SetString("nombre", "Pepe");

            Producto producto = new Producto { 
                id = "prod01",
                nombre = "Atún",
                precio = 10.5
            };

            ConversorParaSesion.ConvertirAjson(HttpContext.Session, "prod", producto);

            List<Producto> productos = new List<Producto>()
            {
                new Producto {
                id = "prod01",
                nombre = "Queso",
                precio = 15
                },
                new Producto {
                id = "prod02",
                nombre = "Atún",
                precio = 10.5
                },
                new Producto {
                id = "prod03",
                nombre = "Arroz",
                precio = 19.2
            }
            };
            ConversorParaSesion.ConvertirAjson(HttpContext.Session, "prods", productos);

            return View();
        }
    }
}
