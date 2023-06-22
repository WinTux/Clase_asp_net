using Microsoft.AspNetCore.Mvc;

namespace Clase_asp_net.Controllers
{
    public class PrincipalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
