using Microsoft.AspNetCore.Mvc;

namespace ProyectoAppWeb.Controllers
{
    public class EjemploQRController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Generar(string codigo) {
            ViewBag.codigo = codigo;
            return View("Index");
        }
    }
}
