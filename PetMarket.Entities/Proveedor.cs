using System;

namespace PetMarket.Entities
{
    public class Proveedor
    {
        public int ProveedorId { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Correo { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public int EstadoId { get; set; }
    }
}