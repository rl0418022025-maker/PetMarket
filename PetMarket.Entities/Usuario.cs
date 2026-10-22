using System;
using System.Collections.Generic;
using System.Text;

namespace PetMarket.Entities
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public int EmpleadoId { get; set; }
        public int RolId { get; set; }
    }
}