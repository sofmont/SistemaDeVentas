using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas
{
    public class Persona
    {
        // Atributos privados
        private int id;
        private string nombre;
        private string telefono;
        private string correo;
        private string direccion;
        private string ciudad;

        // Propiedades públicas
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }

        // Constructor
        public Persona(int id, string nombre, string telefono, string correo, string direccion, string ciudad)
        {
            this.id = id;
            this.nombre = nombre;
            this.telefono = telefono;
            this.correo = correo;
            this.direccion = direccion;
            this.ciudad = ciudad;
        }

        // Método abstracto (polimorfismo)
        public abstract void MostrarInformacion();
    }
}
