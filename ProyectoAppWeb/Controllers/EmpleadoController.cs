using Microsoft.AspNetCore.Mvc;
using ProyectoAppWeb.Models;

namespace ProyectoAppWeb.Controllers
{
    public class EmpleadoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Dato()
        {
            //Recolección de datos
            int num = 25;

            ViewBag.edad = num;
            ViewBag.estatura = 1.71;
            ViewBag.disponible = true;
            ViewBag.nombre = "Pepe Perales";
            ViewBag.fechaincorporacion = DateTime.Now;
            return View();
        }
        public IActionResult Objeto()
        {
            var emp01 = new Empleado
            {
                id = "007",
                nombre = "Ana Rocha",
                foto = "perfil007.jpg",
                salario = 5600,
                diasVacacion = 10
            };
            ViewBag.emp = emp01;
            return View();
        }
        public IActionResult Objetos()
        {
            var empleados = new List<Empleado> {
                new Empleado
                {
                    id = "007",
                    nombre = "Ana Rocha",
                    foto = "perfil007.jpg",
                    salario = 5600,
                    diasVacacion = 10
                },
                new Empleado
                {
                    id = "010",
                    nombre = "Pepe Perales",
                    foto = "perfil010.jpg",
                    salario = 5000,
                    diasVacacion = 5
                },
                new Empleado
                {
                    id = "021",
                    nombre = "Samantha Barrios",
                    foto = "perfil021.jpg",
                    salario = 2700,
                    diasVacacion = 0
                }
            };
            ViewBag.emps = empleados;
            return View();
        }
    }
}
