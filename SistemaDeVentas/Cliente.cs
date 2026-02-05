using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas
{
    public class Cliente: Persona 
    {
        public Cliente( string nombre, string telefono, string correo, string direccion, string ciudad)
        : base( nombre, telefono, correo, direccion, ciudad)
        {
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"CLIENTE: {Nombre}");
            Console.WriteLine($"Teléfono: {Telefono}");
            Console.WriteLine($"Correo: {Correo}");
            Console.WriteLine($"Dirección: {Direccion}, {Ciudad}");
        }
    }
}
