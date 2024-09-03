namespace ProyectoAppWeb.Models
{
    public class Cuenta
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public string Descripcion { get; set; }
        public bool Disponible { get; set; }
        public List<string> Lenguajes { get; set; } // len01: C#, len02: Java, len03: Python, etc. 
        public string Genero { get; set; } // F, M
        public string Cargo { get; set; } // c01: Jefe de unidad, c02: Administrador de sistemas, etc
    }
}
