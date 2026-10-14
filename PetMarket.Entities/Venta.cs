using System;
using System.Collections.Generic;
using System.Text;

namespace PetMarket.Entities
{
    public class Venta
    {
        public int VentaId { get; set; }
        public DateTime Fecha { get; set; }
        public decimal total { get; set; }
        public int ClienteId { get; set; }
        public int EmpleadoId { get; set; }
        public int MetodoPagoId { get; set; }
    }
}
