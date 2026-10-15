using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    internal class Mascota
    {
        public int MascotaId { get; set; }
        public string Nombre { get; set; }
        public string Edad { get; set; }
        public int ClienteId { get; set; }
        public int TipoMascotaId { get; set; }
        public int EstadoId { get; set; }
    }
}
