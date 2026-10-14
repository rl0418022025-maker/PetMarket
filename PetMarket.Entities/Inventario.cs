using System;
using System.Collections.Generic;
using System.Text;

namespace PetMarket.Entities
{
    public class Inventario
    {
        public int InventarioId { get; set; }
        public int ProductoId { get; set; }
        public int CatidadDisponible { get; set; }
        public DateTime FechaActualizacion { get; set; }
    }
}
