using System.ComponentModel.DataAnnotations;

namespace ProyectoAppWeb.Models
{
    public class Cuenta2
    {
        [Required(ErrorMessage ="Es obligatorio poner un nombre de usuario")]
        [MinLength(3,ErrorMessage ="El nombre de usuario debe contar con al menos 3")]
        [MaxLength(15, ErrorMessage = "El nombre de usuario debe contar con 15 letras a lo mucho")]
        public string usuario{ get; set; }
        [Required(ErrorMessage = "Es obligatorio poner un password para el usuario")]
        [MaxLength(10, ErrorMessage = "El password no debe tener más de 10 símbolos")]
        [RegularExpression("((?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#%$]).{6,10})", ErrorMessage = "El password debe contener por lo menos una letra minúscula, una letra mayúscula, un número y uno de los símbolos: @, #, $, %")]
        public string password {  get; set; }

        /*
         [a-z]+ :  a, z, ab, abcz,zba
        [a-zA-Z]*
        [f-z]{3,8}
        [@#%]{3,4}: @@@, ####, @#@#, %##

        ab*c
         */
        [Required]
        [Range(18, 30)]
        public int edad {  get; set; }
        [Required]
        [EmailAddress]
        public string email {  get; set; }
        [Url]
        public string pagina { get; set; }
        // http(s)://sdfsd.dsafsdf.sfdsad.dfsdf
    }
}
