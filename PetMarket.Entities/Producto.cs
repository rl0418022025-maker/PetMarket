using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    internal class Producto
    {
        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public string Descricion { get; set; }
        public decimal PrecioVenta { get; set; }
        public int StockMinimo { get; set; }
        public int CategoriaId { get; set; }
        public int MarcaId { get; set; }

        //Relación con Categoria 
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }

        //Relación con Estado
        public int IdEstado { get; set; }
        public virtual Estado Estado { get; set; }
    }
}
