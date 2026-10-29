using System;
using System.Collections.Generic;
using System.Text;

namespace PetMarket.Entities
{
    public class Marca
    {
        public int MarcaId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int EstadoId { get; set; }
        public string NombreEstado { get; set; }
    }
}
