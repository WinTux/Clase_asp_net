using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clase_asp_net.Models
{
    [Table("Producto")]
    public class Producto
    {
        [Key]
        public string id { get; set; }
        public string nombre { get; set; }
        public double precio { get; set; }
        public string foto { get; set; }
    }
}
