using System.ComponentModel.DataAnnotations;

namespace Clase_asp_net.Models
{
    public class Cuenta
    {
        public int id { get; set; }
        [Required]
        public string usuario { get; set; }
        public string password { get; set; }
        public int edad { get; set; }
        public string email { get; set; }
        public string sitioweb { get; set; }
        public string descripcion { get; set; }
        public bool disponible { get; set; }
        public string genero { get; set; }
        public List<string> lenguajes { get; set; }
        public string cargo { get; set; }
        public List<string> fotos { get; set; }
    }
}
