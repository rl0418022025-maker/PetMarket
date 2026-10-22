using Entities;
using PetMarket.DataAccess;
using PetMarket.Entities;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace PetMarket.DataAccess
{
    public class UsuarioRepository
    {
        public List<Usuario> SelectAll()
        {
            List<Usuario> result = new List<Usuario>();
            using (var conexion = Conexion.ObtenerConexion())
            {
                string query = "SELECT UsuarioId, NombreUsuario, Contraseña, EmpleadoId, RolId, EstadoId FROM Usuario";
                using (var comando = new SqlCommand(query, conexion))
                {
                    using (var lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            Usuario usuario = new Usuario
                            {
                                UsuarioId = Convert.ToInt32(lector["UsuarioId"]),
                                NombreUsuario = lector["NombreUsuario"].ToString(),
                                Contraseña = lector["Contraseña"].ToString(),
                                EmpleadoId = Convert.ToInt32(lector["EmpleadoId"]),
                                RolId = Convert.ToInt32(lector["RolId"]),
                                EstadoId = Convert.ToInt32(lector["EstadoId"])
                            };
                            result.Add(usuario);
                        }
                    }
                }
            }
            return result;
        }

        public int Insert(Usuario entity)
        {
            int result = 0;
            using (var conexion = Conexion.ObtenerConexion())
            {
                string query = "INSERT INTO Usuario (NombreUsuario, Contraseña, EmpleadoId, RolId, EstadoId) VALUES (@NombreUsuario, @Contraseña, @EmpleadoId, @RolId, @EstadoId)";
                using (var comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@NombreUsuario", entity.NombreUsuario);
                    comando.Parameters.AddWithValue("@Contraseña", entity.Contraseña);
                    comando.Parameters.AddWithValue("@EmpleadoId", entity.EmpleadoId);
                    comando.Parameters.AddWithValue("@RolId", entity.RolId);
                    comando.Parameters.AddWithValue("@EstadoId", entity.EstadoId);

                    result = comando.ExecuteNonQuery();
                }
            }
            return result;
        }
    }
}
