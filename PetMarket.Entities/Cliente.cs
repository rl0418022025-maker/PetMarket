using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DUI { get; set; }
        public string Telefono { get; set; }
        public string Correo {  get; set; }
        public string Direccion {  get; set; }
        public int EstadoId { get; set; }
    }
}