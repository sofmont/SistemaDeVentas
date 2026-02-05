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
        private string categoria;
        private double precio;
        private int stock;

        public int Id { get => id; }
        public string Nombre { get => nombre; }
        public string Categoria { get => categoria; }
        public double Precio { get => precio; }
        public int Stock { get => stock; set => stock = value; }

        public Producto(int id, string nombre, string categoria, double precio, int stock)
        {
            this.id = id;
            this.nombre = nombre;
            this.categoria = categoria;
            this.precio = precio;
            this.stock = stock;
        }

        public void MostrarProducto()
        {
            Console.WriteLine($"{Id} - {Nombre} | {Categoria} | Precio: ${Precio} | Stock: {Stock}");
        }
    }
}
