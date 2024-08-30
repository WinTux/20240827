using Microsoft.AspNetCore.Mvc;

namespace ProyectoAppWeb.Controllers
{
    [Route("ParametrosRoute")]
    public class ParametrosRouteController : Controller
    {
        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("Ejemplo1/{ci}")]
        public IActionResult Ejemplo1(int ci)
        {
            ViewBag.ci = ci;
            return View();
        }

        [Route("Ejemplo2/{basee}/{altura}")]
        public IActionResult Ejemplo2(int basee, int altura)
        {
            ViewBag.basee = basee;
            ViewBag.altura = altura;
            ViewBag.area_triangulo = basee * altura / 2;
            return View();
        }
    }
}
