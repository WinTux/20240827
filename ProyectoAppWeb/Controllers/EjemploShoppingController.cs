using Microsoft.AspNetCore.Mvc;
using ProyectoAppWeb.Models;

namespace ProyectoAppWeb.Controllers
{
    public class EjemploShoppingController : Controller
    {
        public IActionResult Index()
        {
            // definir lista productos
            //modelo ProductoModel
            var productoModel = new ProductoModel();
            // viewbag
            ViewBag.productos = productoModel.getTodo();
            return View();
        }
    }
}
