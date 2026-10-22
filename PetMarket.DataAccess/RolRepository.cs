using Entities;
using PetMarket.DataAccess;
using PetMarket.Entities;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace PetMarket.DataAccess
{
    public class RolRepository
    {
        public List<Rol> SelectAll()
        {
            List<Rol> result = new List<Rol>();
            using (var conexion = Conexion.ObtenerConexion())
            {
                string query = "SELECT RolId, Nombre, Descripcion, EstadoId FROM Rol";
                using (var comando = new SqlCommand(query, conexion))
                {
                    using (var lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            Rol rol = new Rol
                            {
                                RolId = Convert.ToInt32(lector["RolId"]),
                                Nombre = lector["Nombre"].ToString(),
                                Descripcion = lector["Descripcion"] != DBNull.Value ? lector["Descripcion"].ToString() : null,
                                EstadoId = Convert.ToInt32(lector["EstadoId"])
                            };
                            result.Add(rol);
                        }
                    }
                }
            }
            return result;
        }

        public int Insert(Rol entity)
        {
            int result = 0;
            using (var conexion = Conexion.ObtenerConexion())
            {
                string query = "INSERT INTO Rol (Nombre, Descripcion, EstadoId) VALUES (@Nombre, @Descripcion, @EstadoId)";
                using (var comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    comando.Parameters.AddWithValue("@Descripcion", entity.Descripcion ?? (object)DBNull.Value);
                    comando.Parameters.AddWithValue("@EstadoId", entity.EstadoId);

                    result = comando.ExecuteNonQuery();
                }
            }
            return result;
        }
    }
}
