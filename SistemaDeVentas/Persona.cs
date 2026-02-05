using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas
{
    public abstract class Persona
    {
        // Atributos privados
        private string nombre;
        private string telefono;
        private string correo;
        private string direccion;
        private string ciudad;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }

        
        public Persona(string nombre, string telefono, string correo, string direccion, string ciudad)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            this.correo = correo;
            this.direccion = direccion;
            this.ciudad = ciudad;
        }

         
        public abstract void MostrarInformacion();
    }
}
