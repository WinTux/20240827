using Microsoft.AspNetCore.Mvc;

namespace ProyectoAppWeb.Controllers
{
    [Route("ParametrosQueryString")]
    public class ParametrosQueryStringController : Controller
    {
        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("Ejemplo1")]
        public IActionResult Ejemplo1([FromQuery(Name = "id")] int id)
        {
            ViewBag.ci = id;
            return View("ejem1");
        }
        [Route("Ejemplo2")]
        public IActionResult Ejemplo2([FromQuery(Name = "id")] int id, [FromQuery(Name = "n")] string nombre)
        {
            ViewBag.ci = id;
            ViewBag.nombre = nombre;
            return View("ejem2");
        }

        [Route("Ejemplo3")]
        public IActionResult Ejemplo3()
        {
            int id = int.Parse(HttpContext.Request.Query["id"]);
            string nombre = HttpContext.Request.Query["n"];
            ViewBag.ci = id;
            ViewBag.nombre = nombre;
            return View("ejem2");
        }
    }
}
