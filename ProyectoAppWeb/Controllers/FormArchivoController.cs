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
        public IActionResult Guardar(Producto producto, IFormFile photo)
        {
            if (photo == null || photo.Length == 0)
                return Content("Archivo no valido");
            else
            {
                var ruta = Path.Combine(this._webHostEnvironment.WebRootPath,"imagenes", photo.FileName);
                var flujo = new FileStream(ruta, FileMode.Create);
                photo.CopyToAsync(flujo);
                producto.Foto = photo.FileName;
            }
            ViewBag.producto = producto;
            return View("Resultado");
        }
        public IActionResult Index2()
        {
            return View("Index2", new Producto2());
        }
        [HttpPost]
        public IActionResult Guardar2(Producto2 producto, IFormFile[] fotos)
        {
            if (fotos == null || fotos.Length == 0)
                return Content("Archivo(s) no valido(s)");
            else
            {
                producto.Fotos = new List<string>();
                foreach (IFormFile fotito in fotos) {
                    var ruta = Path.Combine(this._webHostEnvironment.WebRootPath, "imagenes", fotito.FileName);
                    var flujo = new FileStream(ruta, FileMode.Create);
                    fotito.CopyToAsync(flujo);
                    producto.Fotos.Add(fotito.FileName);
                }
                
            }
            ViewBag.producto = producto;
            return View("Resultado2");
        }
    }
}
