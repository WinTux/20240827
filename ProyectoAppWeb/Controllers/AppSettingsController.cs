using Microsoft.AspNetCore.Mvc;

namespace ProyectoAppWeb.Controllers
{
    public class AppSettingsController : Controller
    {
        private IConfiguration configuration;

        public AppSettingsController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public IActionResult Index()
        {
            ViewBag.ejemplo1 = configuration["Mensaje"];
            ViewBag.ejemplo2 = configuration["MisConfiguraciones:Config1"];
            ViewBag.ejemplo3 = configuration["MisConfiguraciones:Config2"];
            ViewBag.ejemplo4 = configuration["MisConfiguraciones:Config3"];
            ViewBag.ejemplo5 = configuration["Log:AlcanceGlobal"];
            ViewBag.ejemplo6 = configuration["Log:Debug:LogLevel:Default"];
            return View();
        }
    }
}
