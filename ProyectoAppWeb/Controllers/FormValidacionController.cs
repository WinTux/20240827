using Microsoft.AspNetCore.Mvc;
using ProyectoAppWeb.Models;

namespace ProyectoAppWeb.Controllers
{
    public class FormValidacionController : Controller
    {
        public IActionResult Index()
        {
            return View("Index", new Cuenta2());
        }
        [HttpPost]
        public IActionResult Guardar(Cuenta2 cuenta)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Cuenta = cuenta;
                return View("Resultado");
            }else
                return View("Index");
        }
    }
}
