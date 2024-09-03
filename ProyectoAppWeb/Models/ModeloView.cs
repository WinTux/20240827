using Microsoft.AspNetCore.Mvc.Rendering;

namespace ProyectoAppWeb.Models
{
    public class ModeloView
    {
        public Cuenta cuenta { get; set; }
        public List<Lenguaje> lenguajes { get; set; }
        public SelectList cargos { get; set; }
    }
}
