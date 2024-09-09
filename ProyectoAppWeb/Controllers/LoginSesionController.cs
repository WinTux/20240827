using Microsoft.AspNetCore.Mvc;

namespace ProyectoAppWeb.Controllers
{
    public class LoginSesionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string usuario, string password)
        {
            if (usuario != null && password != null && usuario.Equals("Pepe") && password.Equals("123456"))
            {
                HttpContext.Session.SetString("usuario", usuario);
                return View("Exito");
            }
            else {
                ViewBag.error = "Usuario o password incorrecto";
                return View("Index");
            }
            
        }
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("usuario");
            return RedirectToAction("Index");
        }
    }
}
