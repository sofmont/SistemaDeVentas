using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas
{
    public class OrdenVenta
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public Empleado Empleado { get; set; }
        public List<Producto> Productos { get; set; } = new List<Producto>();
        public double Total { get; set; }
        public DateTime Fecha { get; set; }

        public OrdenVenta(int id, Cliente cliente, Empleado empleado)
        {
            Id = id;
            Cliente = cliente;
            Empleado = empleado;
            Fecha = DateTime.Now;
        }

        public void AgregarProducto(Producto p)
        {
            if (p.Stock > 0)
            {
                Productos.Add(p);
                Total += p.Precio;
                p.Stock--;
            }
            else
            {
                Console.WriteLine("Producto sin stock.");
            }
        }

        public void MostrarOrden()
        {
            Console.WriteLine($"\nORDEN #{Id}");
            Console.WriteLine($"Cliente: {Cliente.Nombre}");
            Console.WriteLine($"Empleado: {Empleado.Nombre}");
            Console.WriteLine($"Fecha: {Fecha}");

            Console.WriteLine("Productos:");
            foreach (var p in Productos)
                Console.WriteLine($"- {p.Nombre} ${p.Precio}");

            Console.WriteLine($"TOTAL: ${Total}");
        }
    }
}
