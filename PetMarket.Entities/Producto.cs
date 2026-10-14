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
        public decimal PrecioVenta { get; set; }
        public int StockMinimo { get; set; }
        public int CategoriaId { get; set; }
        public string Categoria { get; set; }
        public int MarcaId { get; set; }
        public string Marca { get; set; }
        public int EstadoId { get; set; }
        public string Estado { get; set; }
    }
}