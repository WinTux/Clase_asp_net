using Clase_asp_net.Models;
using Microsoft.AspNetCore.Mvc;

namespace Clase_asp_net.Controllers
{
    [Route("empleado")]
    public class EmpleadoController : Controller
    {
        private IConfiguration configuration;
        public EmpleadoController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        [Route("index")]
        [Route("")]
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

            //Pasandole un objeto Empleado
            var emp = new Empreado { 
                ci = 3301,
                nombre = "Pepe Perales",
                estatura = 1.82,
                peso = 70,
                foto = "uno.jpeg"
            };
            ViewBag.empleado = emp;

            //Pasandole un conjunto de objetos Empleado
            var emps = new List<Empreado> {
                new Empreado {
                    ci = 3302,
                    nombre = "ana Sosa",
                    estatura = 1.70,
                    peso = 68,
                    foto = "uno.jpeg"
                },
                new Empreado {
                    ci = 3303,
                    nombre = "Sofía Rocha",
                    estatura = 1.78,
                    peso = 60,
                    foto = "dos.jpeg"
                },
                new Empreado {
                    ci = 3304,
                    nombre = "Carlos Ballarta",
                    estatura = 1.68,
                    peso = 50,
                    foto = "tres.jpeg"
                }
            };
            ViewBag.empleados = emps;

            return View();
        }
        [Route("detalles")]
        [Route("detallazos")]
        public IActionResult Ejemplo1() {
            ViewBag.variable1 = configuration["Texto"];
            ViewBag.variable2 = configuration["VariablesConfig:var1"];
            ViewBag.variable3 = configuration["VariablesConfig:var2"];
            ViewBag.variable4 = configuration["VariablesConfig:var3"];
            ViewBag.variable5 = configuration["VariablesConfig:varx:default"];
            ViewBag.variable6 = configuration["VariablesConfig:varx:advanced:extremo"];

            return View("Configuraciones");
        }
    }
}
