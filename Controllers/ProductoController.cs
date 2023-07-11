using Clase_asp_net.Extra;
using Clase_asp_net.Models;
using Microsoft.AspNetCore.Mvc;

namespace Clase_asp_net.Controllers
{
    public class ProductoController : Controller
    {
        private readonly DDBBContext ddbb;
        public ProductoController(DDBBContext ddbb)
        {
            this.ddbb = ddbb;
        }
        public IActionResult Index()
        {
            // Read
            ViewBag.productos = ddbb.Productos.ToList();
            return View();
        }
        [HttpGet]
        public IActionResult Agregar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Agregar(Producto producto)
        {
            // Create
            ddbb.Productos.Add(producto);
            ddbb.SaveChanges();
            return RedirectToAction("Index");
        }

        [Route("Modificar/{id}")]
        [HttpGet]
        public IActionResult Modificar(string id)
        {
            Producto prod = ddbb.Productos.FirstOrDefault<Producto>(p => p.id == id);
            return View("Modificar",prod);
        }
        [HttpPost]
        public IActionResult Modificar(Producto producto)
        {
            // Update
            ddbb.Entry(producto).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            ddbb.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Eliminar(string id)
        {
            // Delete
            ddbb.Productos.Remove(ddbb.Productos.Find(id));
            ddbb.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
