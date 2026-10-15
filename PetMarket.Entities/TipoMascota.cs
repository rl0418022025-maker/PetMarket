using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    internal class TipoMascota
    {
        public int TipoMascotaId { get; set; }
        public string Especie { get; set; }
        public string Descripcion { get; set; }
        public int EstadoId { get; set; }
    }
}