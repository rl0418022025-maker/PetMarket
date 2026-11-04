using System;
using System.Collections.Generic;
using System.Text;

namespace PetMarket.Entities
{
    public class Producto
    {
        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public int CategoriaId { get; set; }
        public int MarcaId { get; set; }
        public int EstadoId { get; set; }
    }
}