using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    internal class Cliente
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DUI { get; set; }
        public string Telefono { get; set; }
        public int EstadoId { get; set; }
    }
}