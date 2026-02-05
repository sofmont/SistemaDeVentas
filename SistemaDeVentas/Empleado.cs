using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas
{
    public class Empleado: Persona
    {
        public string Puesto { get; set; }

        public Empleado(string nombre, string telefono, string correo, string direccion, string ciudad, string puesto)
            : base(nombre, telefono, correo, direccion, ciudad)
        {
            Puesto = puesto;
        }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"EMPLEADO: {Nombre}");
            Console.WriteLine($"Puesto: {Puesto}");
            Console.WriteLine($"Teléfono: {Telefono}");
            Console.WriteLine($"Correo: {Correo}");

        }
    }
}
