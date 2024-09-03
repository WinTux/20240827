using Microsoft.AspNetCore.Mvc;
using ProyectoAppWeb.Models;

namespace ProyectoAppWeb.Controllers
{
    public class FormArchivoController : Controller
    {
        private IWebHostEnvironment _webHostEnvironment;
        public FormArchivoController(IWebHostEnvironment _webHostEnvironment)
        {
            this._webHostEnvironment = _webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View("Index", new Producto());
        }
        [HttpPost]
        public IActionResult Guardar(Producto producto, IFormFile foto)
        {
            if (foto == null || foto.Length == 0)
                return Content("Archivo no valido");
            else
            {
                var ruta = Path.Combine(this._webHostEnvironment.WebRootPath,"imagenes", foto.FileName);
                return View("Resultado");
            }
            
        }
    }
}
