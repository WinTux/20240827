using System.ComponentModel.DataAnnotations;

namespace ProyectoAppWeb.Models
{
    public class Producto2
    {
        public string Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        
        public double Precio { get; set; }
        public string observaciones { get; set; }
        public List<string> Fotos { get; set; }
    }
}
