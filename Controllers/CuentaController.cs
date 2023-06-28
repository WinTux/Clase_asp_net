using Clase_asp_net.Models;
using Microsoft.AspNetCore.Mvc;

namespace Clase_asp_net.Controllers
{
    public class CuentaController : Controller
    {
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
                new Cargo{ id= "c01", nombre = "Auxiliar de desarrollo"},
                new Cargo{ id= "c01", nombre = "Programador senior"},
                new Cargo{ id= "c01", nombre = "Jefe de Dpto."}
            };
            cuentaModelView.cargos = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(c,"id", "nombre");
            return View("Index",cuentaModelView);
        }
    }
}
