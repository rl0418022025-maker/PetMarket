using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class DetalleCompra
    {
        public int DetalleCompraId { get; set; }
        public int CompraId { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitaio { get; set; }
        public decimal TotalPagar { get; set; }
    }
}
