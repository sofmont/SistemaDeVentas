using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas
{
    public class Inventario
    {
        public List<Producto> Productos { get; } = new List<Producto>();

        public void AgregarProducto(Producto producto)
        {
            Productos.Add(producto);
        }

        public void MostrarInventario()
        {
            foreach (var p in Productos)
                p.MostrarProducto();
        }

        public Producto BuscarProducto(int id)
        {
            foreach (var p in Productos)
                if (p.Id == id)
                    return p;

            return null;
        }
    }
}
