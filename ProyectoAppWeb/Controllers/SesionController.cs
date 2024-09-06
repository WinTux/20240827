using Microsoft.AspNetCore.Mvc;
using ProyectoAppWeb.Models;

namespace ProyectoAppWeb.Controllers
{
    public class SesionController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.SetInt32("edad", 23);
            HttpContext.Session.SetString("usuario", "Pepe");
            //HttpContext.Session.SetInt32("usuario", new Producto());
            return View();
        }
    }
}
