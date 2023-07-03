using System.ComponentModel.DataAnnotations;

namespace Clase_asp_net.Models
{
    public class Cuenta
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Por favor, introduzca su un nombre de usuario")]
        [MinLength(5, ErrorMessage = "Por favor, introduzca un nombre de usuario de al menos 5 letras")]
        [MaxLength(15, ErrorMessage = "Por favor, introduzca un nombre de usuario con un máximo de 15 letras")]
        public string usuario { get; set; }
        [Required]
        [MinLength(5)]
        [MaxLength(10)]
        [RegularExpression("((?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[#@%$]).{5,10})", ErrorMessage = "La contraseña debe tener al menos un número, una letra minúscula, una letra mayúscula y un símbolo #@%$")]
        public string password { get; set; }
        [Required]
        [Range(18,55)]
        public int edad { get; set; }
        [Required]
        [EmailAddress]
        public string email { get; set; }
        [Url]
        public string sitioweb { get; set; }
        public string descripcion { get; set; }
        public bool disponible { get; set; }
        public string genero { get; set; }
        public List<string> lenguajes { get; set; }
        public string cargo { get; set; }
        public List<string> fotos { get; set; }
    }
}

/*
 Expresiones regulares (RE)

456SDF
1234ERR
DFS545
D5F4

pepe@abc.asd

\d{4}

[a-z]

[A-Z]

[a-zA-Z]

[az]

a*ba -> aa, aba, abba, abbbbba

https://asd.posi

\d{4}[A-Z]

\d{3,4}[A-Z]{3}

 */