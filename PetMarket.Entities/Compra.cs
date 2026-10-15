using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Compra
    {
        public int CompraId { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public int ProveedorId { get; set; }
    }
}