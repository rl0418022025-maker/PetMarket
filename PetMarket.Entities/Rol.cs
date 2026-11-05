using System;

namespace PetMarket.Entities
{
    public class Rol
    {
        public int RolId { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public int EstadoId { get; set; }
    }
}