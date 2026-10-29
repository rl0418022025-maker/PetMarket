using System;
using System.Collections.Generic;
using System.Text;

namespace PetMarket.Entities
{
    public class TipoMascota
    {
        public int TipoMascotaId { get; set; }
        public string Especie { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public int EstadoId { get; set; }
        public string NombreEstado { get; set; } = string.Empty;
    }
}