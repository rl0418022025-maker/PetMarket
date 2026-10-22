using Entities;
using PetMarket.DataAccess;
using PetMarket.Entities;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace PetMarket.DataAccess
{
    public class TipoMascotaRepository
    {
        public List<TipoMascota> SelectAll()
        {
            List<TipoMascota> result = new List<TipoMascota>();
            using (var conexion = Conexion.ObtenerConexion())
            {
                string query = "SELECT TipoMascotaId, Especie, Descripcion, EstadoId FROM TipoMascota";
                using (var comando = new SqlCommand(query, conexion))
                {
                    using (var lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            TipoMascota tipoMascota = new TipoMascota
                            {
                                TipoMascotaId = Convert.ToInt32(lector["TipoMascotaId"]),
                                Especie = lector["Especie"].ToString(),
                                Descripcion = lector["Descripcion"] != DBNull.Value ? lector["Descripcion"].ToString() : null,
                                EstadoId = Convert.ToInt32(lector["EstadoId"])
                            };
                            result.Add(tipoMascota);
                        }
                    }
                }
            }
            return result;
        }

        public int Insert(TipoMascota entity)
        {
            int result = 0;
            using (var conexion = Conexion.ObtenerConexion())
            {
                string query = "INSERT INTO TipoMascota (Especie, Descripcion, EstadoId) VALUES (@Especie, @Descripcion, @EstadoId)";
                using (var comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@Especie", entity.Especie);
                    comando.Parameters.AddWithValue("@Descripcion", entity.Descripcion ?? (object)DBNull.Value);
                    comando.Parameters.AddWithValue("@EstadoId", entity.EstadoId);

                    result = comando.ExecuteNonQuery();
                }
            }
            return result;
        }
    }
}