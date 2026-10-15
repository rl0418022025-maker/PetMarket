using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    internal class Empleado
    {
        public int EmpleadoId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DUI { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Cargo { get; set; }
        public int EstadoId { get; set; }
    }
}