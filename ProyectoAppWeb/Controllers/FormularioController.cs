using Microsoft.AspNetCore.Mvc;
using ProyectoAppWeb.Models;

namespace ProyectoAppWeb.Controllers
{
    public class FormularioController : Controller
    {
        public IActionResult Index()
        {
            var modeloView = new ModeloView();
            modeloView.cuenta = new Cuenta()
            {
                Id = 1,
                Disponible = true,
                Genero = "M"
            };
            modeloView.lenguajes = new List<Lenguaje>()
            {
                new Lenguaje(){Id = "len01",Nombre="C#", estaTickeado=true},
                new Lenguaje(){Id = "len02",Nombre="Python", estaTickeado=false},
                new Lenguaje(){Id = "len03",Nombre="Java", estaTickeado=true},
                new Lenguaje(){Id = "len04",Nombre="C++", estaTickeado=false},
                new Lenguaje(){Id = "len05",Nombre="Java Script", estaTickeado=false}
            };
            List<Cargo> cargos = new List<Cargo>()
            { 
                new Cargo(){Id = "c01",Nombre="Jefe de departamento de sistemas"},
                new Cargo(){Id = "c02",Nombre="Administrador de sistemas"},
                new Cargo(){Id = "c03",Nombre="Técnico auxiliar de sistemas"}
            };
            modeloView.cargos = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(cargos,"Id","Nombre");
            return View("Index", modeloView);
        }
        [HttpPost]
        public ActionResult Guardar(ModeloView modeloView, List<Lenguaje> lenguajes) {
            modeloView.cuenta.Lenguajes = new List<string>();
            foreach (var len in lenguajes)
                if (len.estaTickeado)
                    modeloView.cuenta.Lenguajes.Add(len.Id);
            ViewBag.cuenta = modeloView.cuenta;
            return View("Resultado");
        }
    }
}
