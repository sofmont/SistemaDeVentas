using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas
{
    public class SistemaVentas
    {
        public Inventario inventario = new Inventario();
        public List<OrdenVenta> ordenes = new List<OrdenVenta>();

        public void RegistrarOrden(OrdenVenta orden)
        {
            ordenes.Add(orden);
        }

        public double CalcularIngresos()
        {
            double total = 0;
            foreach (var o in ordenes)
                total += o.Total;

            return total;
        }
    }
}
