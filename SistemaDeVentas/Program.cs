using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SistemaVentas sistema = new SistemaVentas();
            int opcion;
            int idOrden = 1;

            // Inventario inicial
            sistema.inventario.AgregarProducto(new Producto(1, "Laptop HP", "Laptop", 15000, 5));
            sistema.inventario.AgregarProducto(new Producto(2, "Mouse Logitech", "Mouse", 300, 10));
            sistema.inventario.AgregarProducto(new Producto(3, "Teclado Redragon", "Teclado", 800, 6));
            sistema.inventario.AgregarProducto(new Producto(4, "RAM 8GB Kingston", "RAM", 900, 8));

            do
            {
                Console.WriteLine("--- SISTEMA DE VENTAS CON ORDENES ---");
                Console.WriteLine("1. Ver inventario");
                Console.WriteLine("2. Crear orden de venta");
                Console.WriteLine("3. Ver ingresos totales");
                Console.WriteLine("0. Salir");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        sistema.inventario.MostrarInventario();
                        break;

                    case 2:
                        Console.Write("Nombre del cliente: ");
                        Cliente cliente = new Cliente(Console.ReadLine());

                        Console.Write("Nombre del empleado: ");
                        Empleado empleado = new Empleado(Console.ReadLine());

                        OrdenVenta orden = new OrdenVenta(idOrden++, cliente, empleado);
                        string seguir;

                        do
                        {
                            sistema.inventario.MostrarInventario();
                            Console.Write("ID del producto: ");
                            int id = int.Parse(Console.ReadLine());

                            Producto p = sistema.inventario.BuscarProducto(id);

                            if (p != null)
                                orden.AgregarProducto(p);
                            else
                                Console.WriteLine("Producto no encontrado.");

                            Console.Write("¿Agregar otro producto? para seguir seleccionando productos pulsa la letra s: ");
                            seguir = Console.ReadLine();

                        } while (seguir == "s");

                        orden.MostrarOrden();
                        sistema.RegistrarOrden(orden);
                        break;

                    case 3:
                        Console.WriteLine("Ingresos totales: $" + sistema.CalcularIngresos());
                        break;
                }

            } while (opcion != 0);
        }
    }
}
