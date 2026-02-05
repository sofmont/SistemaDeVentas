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
        public void ModificarProducto()
        {
            Console.Write("ID del producto a modificar: ");
            int id = int.Parse(Console.ReadLine());

            Producto producto = BuscarProducto(id);

            if (producto != null)
            {
                Console.WriteLine("1. Cambiar nombre");
                Console.WriteLine("2. Cambiar precio");
                Console.WriteLine("3. Cambiar stock");
                Console.Write("Seleccione opción: ");

                int op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.Write("Nuevo nombre: ");
                        producto.Nombre = Console.ReadLine();
                        break;

                    case 2:
                        Console.Write("Nuevo precio: ");
                        producto.Precio = double.Parse(Console.ReadLine());
                        break;

                    case 3:
                        Console.Write("Nuevo stock: ");
                        producto.Stock = int.Parse(Console.ReadLine());
                        break;
                }

                Console.WriteLine("Producto actualizado correctamente.");
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }
        }
    }
}


