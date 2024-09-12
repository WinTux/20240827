namespace ProyectoAppWeb.Models
{
    public class ProductoModel
    {
        private List<Producto> productos;
        public ProductoModel() {
            productos = new List<Producto>() { 
                new Producto
                {
                    Id = "prod01",
                    Nombre = "Atun oficial",
                    Precio = 12.5,
                    Foto = "atun.webp"
                },
                new Producto
                {
                    Id = "prod02",
                    Nombre = "Atun Van Camps",
                    Precio = 22.5,
                    Foto = "atun2.webp"
                },
                new Producto
                {
                    Id = "prod03",
                    Nombre = "Atun Van Camps Lite",
                    Precio = 17.0,
                    Foto = "atun3.webp"
                },
                new Producto
                {
                    Id = "prod04",
                    Nombre = "Atun oficial Pack",
                    Precio = 20.2,
                    Foto = "atunes.webp"
                }
            };
        }
        public List<Producto> getTodo() {
            return productos;
        }
        public Producto getById(string id) {
            return productos.Single(p=>p.Id == id);// select p.* from Producto p where p.Id = id;
        }
    }
}
