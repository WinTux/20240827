using Microsoft.AspNetCore.Mvc;
using ProyectoAppWeb.Herramientas;
using ProyectoAppWeb.Models;

namespace ProyectoAppWeb.Controllers
{
    public class SesionController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.SetInt32("edad", 23);
            HttpContext.Session.SetString("usuario", "Pepe");

            Producto prod = new Producto { 
                Id = "prod001",
                Nombre = "Atun Van Camps Extra Forte",
                Precio = 30.50,
                Foto = "atun.webp"
            };

            ConversorParaSesion.SetObjetoAJson(HttpContext.Session, "prod", prod);

            List<Producto> prods = new List<Producto>() {
                new Producto {
                Id = "prod002",
                Nombre = "Atun Van Camps ",
                Precio = 20,
                Foto = "atun2.webp"
            },
                new Producto {
                Id = "prod003",
                Nombre = "Atun Van Camps - Variante",
                Precio = 23.1,
                Foto = "atun3.webp"
            },
                new Producto {
                Id = "prod004",
                Nombre = "Atun Van Camps Pack",
                Precio = 30,
                Foto = "atunes.webp"
            },
                new Producto {
                Id = "prod005",
                Nombre = "Atun Van Camps Duo",
                Precio = 30.50,
                Foto = "atunes2.webp"
            }
            };

            ConversorParaSesion.SetObjetoAJson(HttpContext.Session, "prods", prods);

            return View();
        }
    }
}
