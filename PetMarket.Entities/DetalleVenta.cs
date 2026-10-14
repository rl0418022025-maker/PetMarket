using System;
using System.Collections.Generic;
using System.Text;

namespace PetMarket.Entities
{
    public class DetalleVenta
    {
        public int DetalleVentaId { get; set; }
        public int VentaId { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal Subtotal { get; set; }
    }
}
