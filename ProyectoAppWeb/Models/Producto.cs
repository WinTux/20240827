using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoAppWeb.Models
{
    [Table("Producto")]
    public class Producto
    {
        [Key]
        public string Id { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        [Column("Foto")]
        public string Foto { get; set; }
    }
}
