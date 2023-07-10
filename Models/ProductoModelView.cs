namespace Clase_asp_net.Models
{
    public class ProductoModelView
    {
        private List<Producto> productos;
        public ProductoModelView()
        {
            productos = new List<Producto>() {
                new Producto {
                    id = "prod01",
                    nombre = "Queso",
                    precio = 15M,
                    foto = "queso.jpg"
                },
                new Producto {
                    id = "prod02",
                    nombre = "Atún",
                    precio = 10.5M,
                    foto = "atun.jpg"
                },
                new Producto {
                    id = "prod03",
                    nombre = "Arroz",
                    precio = 19.2M,
                    foto = "uno.jpeg"
                }
            };
        }

        public List<Producto> getTodos() {
            return productos;
        }

        public Producto getProducto(string codigo) {
            return productos.Single(p => p.id.Equals(codigo) );
            // SELECT * FROM productos p WHERE p.id  == codigo;
        }
    }
}
