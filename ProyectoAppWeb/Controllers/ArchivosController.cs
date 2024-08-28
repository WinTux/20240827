using Microsoft.AspNetCore.Mvc;

namespace ProyectoAppWeb.Controllers
{
    public class ArchivosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
