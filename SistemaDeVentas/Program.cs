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
                Console.Clear();
                Console.WriteLine("=== SISTEMA DE VENTAS ===");
                Console.WriteLine("1. Mostrar inventario");
                Console.WriteLine("2. Crear orden de venta");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        sistema.inventario.MostrarInventario();
                        Console.ReadKey();
                        break;

                    case 2:

                        Console.WriteLine("=== DATOS DEL CLIENTE ===");

                        Console.Write("ID: ");
                        int idCliente = int.Parse(Console.ReadLine());

                        Console.Write("Nombre: ");
                        string nombreCliente = Console.ReadLine();

                        Console.Write("Teléfono: ");
                        string telCliente = Console.ReadLine();

                        Console.Write("Correo: ");
                        string correoCliente = Console.ReadLine();

                        Console.Write("Dirección: ");
                        string dirCliente = Console.ReadLine();

                        Console.Write("Ciudad: ");
                        string ciudadCliente = Console.ReadLine();

                        Cliente cliente = new Cliente( nombreCliente, telCliente, correoCliente, dirCliente, ciudadCliente);


                        Console.WriteLine("\n=== DATOS DEL EMPLEADO ===");

                        Console.Write("ID: ");
                        int idEmpleado = int.Parse(Console.ReadLine());

                        Console.Write("Nombre: ");
                        string nombreEmpleado = Console.ReadLine();

                        Console.Write("Teléfono: ");
                        string telEmpleado = Console.ReadLine();

                        Console.Write("Correo: ");
                        string correoEmpleado = Console.ReadLine();

                        Console.Write("Dirección: ");
                        string dirEmpleado = Console.ReadLine();

                        Console.Write("Ciudad: ");
                        string ciudadEmpleado = Console.ReadLine();

                        Console.Write("Puesto: ");
                        string puesto = Console.ReadLine();

                        Empleado empleado = new Empleado( nombreEmpleado, telEmpleado, correoEmpleado, dirEmpleado, ciudadEmpleado, puesto);


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
                                Console.WriteLine("Producto no encontrado");

                            Console.Write("¿Agregar otro producto? (Tecla s para agregar otro producto): ");
                            seguir = Console.ReadLine();

                        } while (seguir.ToLower() == "s");

                        orden.MostrarOrden();
                        Console.ReadKey();
                        break;

                }

            } while (opcion != 3);
        }
    }
}
