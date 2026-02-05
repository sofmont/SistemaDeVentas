using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas
{
    public class Producto
    {
        private int id;
        private string nombre;
        private double precio;
        private int stock;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }

        public Producto(int id, string nombre, double precio, int stock)
        {
            this.id = id;
            this.nombre = nombre;
            this.precio = precio;
            this.stock = stock;
        }

        public void MostrarProducto()
        {
            Console.WriteLine($"{Id} - {Nombre} | Precio: ${Precio} | Stock: {Stock}");
        }
    }
}
