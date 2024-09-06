using System.ComponentModel.DataAnnotations;

namespace ProyectoAppWeb.Models
{
    public class Producto2
    {
        public string Id { get; set; }
        [Required(ErrorMessage ="Debe poner un nombre de producto")]
        public string Nombre { get; set; }
        [Required]
        [Range(minimum: 5,maximum:500, ErrorMessage ="El precio debe estar entre Bs.5 y Bs.500")]
        public double Precio { get; set; }
        public string observaciones { get; set; }
        public List<string> Fotos { get; set; }
    }
}
