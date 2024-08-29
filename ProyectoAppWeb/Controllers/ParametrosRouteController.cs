using Microsoft.AspNetCore.Mvc;

namespace ProyectoAppWeb.Controllers
{
    public class ParametrosRouteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("ejem1/{ci}")]
        public IActionResult Ejemplo1(int ci)
        {
            return View();
        }
    }
}
