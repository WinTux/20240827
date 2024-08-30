namespace ProyectoAppWeb.Models
{
    public class Cuenta
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public string Descripcion { get; set; }
        public bool Disponible { get; set; }
        public List<string> Lenguajes { get; set; }
        public string Genero { get; set; }
        public string Cargo { get; set; }
    }
}
