using Microsoft.EntityFrameworkCore;

namespace ProyectoAppWeb.Models
{
    public class ShoppingContext : DbContext
    {
        public virtual DbSet<Producto> Productos { get; set; }
        public ShoppingContext()
        {
            
        }
        public ShoppingContext(DbContextOptions<ShoppingContext> op) : base(op) {
        
        }
        
    }
}
