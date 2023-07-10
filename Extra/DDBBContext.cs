using Clase_asp_net.Models;
using Microsoft.EntityFrameworkCore;

namespace Clase_asp_net.Extra
{
    public class DDBBContext : DbContext
    {
        public virtual DbSet<Producto> Productos { get; set; }
        public DDBBContext()
        {
            
        }
        public DDBBContext(DbContextOptions<DDBBContext> op) : base(op)
        {

        }
    }
}
