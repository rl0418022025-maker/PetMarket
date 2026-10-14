using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    internal class Categoria
    {
        public int CategoriaId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public int IdEstado { get; set; }
        public virtual Estado Estado { get; set; }
    }
}
