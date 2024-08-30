using Microsoft.AspNetCore.Mvc;

namespace ProyectoAppWeb.Controllers
{
    public class FormularioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
