using Clase_asp_net.Models;
using Microsoft.AspNetCore.Mvc;

namespace Clase_asp_net.Controllers
{
    public class CuentaController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var cuentaModelView = new CuentaModelView();
            cuentaModelView.cuenta = new Cuenta() { 
                id = 123,
                disponible = true,
                genero = "f" //f: femenino, m: masculino
            };
            cuentaModelView.lenguajes = new List<Lenguaje>() { 
                new Lenguaje(){ 
                    id = "len01",
                    nombre = "C#",
                    tickeado = true
                },
                new Lenguaje(){
                    id = "len02",
                    nombre = "Python",
                    tickeado = false
                },
                new Lenguaje(){
                    id = "len03",
                    nombre = "Java",
                    tickeado = false
                },
                new Lenguaje(){
                    id = "len04",
                    nombre = "C++",
                    tickeado = false
                }
            };
            var c = new List<Cargo>() { 
                new Cargo{ id= "c01", nombre = "Pasante"},
                new Cargo{ id= "c02", nombre = "Auxiliar de desarrollo"},
                new Cargo{ id= "c03", nombre = "Programador senior"},
                new Cargo{ id= "c04", nombre = "Jefe de Dpto."}
            };
            cuentaModelView.cargos = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(c,"id", "nombre");
            return View("Index",cuentaModelView);
        }
        [HttpPost]
        public IActionResult Registro(CuentaModelView cuentaModelView, List<Lenguaje> lenguajes)
        {
            cuentaModelView.cuenta.lenguajes = new List<string>();
            foreach(var l in lenguajes)
            {
                if (l.tickeado)
                    cuentaModelView.cuenta.lenguajes.Add(l.id);
            }

            ViewBag.cuenta = cuentaModelView.cuenta;
            return View("Registrado");
        }
    }
}
