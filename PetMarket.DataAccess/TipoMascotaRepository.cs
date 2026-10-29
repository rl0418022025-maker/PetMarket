using Microsoft.Data.SqlClient;
using PetMarket.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace PetMarket.DataAccess
{
    public class TipoMascotaRepository
    {
        private readonly ConnectionFactory _connectionFactory;

        public TipoMascotaRepository(ConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public List<TipoMascota> SelectAll()
        {
            List<TipoMascota> result = new List<TipoMascota>();

            using (SqlConnection conn = _connectionFactory.CreateConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_ListarTiposMascota", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            TipoMascota entity = new TipoMascota
                            {
                                TipoMascotaId = Convert.ToInt32(dr["TipoMascotaId"]),
                                Especie = dr["Especie"].ToString()!,
                                Descripcion = dr["Descripcion"] != DBNull.Value ? dr["Descripcion"].ToString()! : string.Empty,
                                EstadoId = Convert.ToInt32(dr["EstadoId"]),
                                NombreEstado = dr["NombreEstado"] != DBNull.Value ? dr["NombreEstado"].ToString()! : string.Empty
                            };

                            result.Add(entity);
                        }
                    }
                }
            }

            return result;
        }

        public int Insert(TipoMascota entity)
        {
            using (SqlConnection conn = _connectionFactory.CreateConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_InsertarTipoMascota", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Especie", entity.Especie);
                    cmd.Parameters.AddWithValue("@Descripcion", string.IsNullOrWhiteSpace(entity.Descripcion) ? (object)DBNull.Value : entity.Descripcion);
                    cmd.Parameters.AddWithValue("@EstadoId", entity.EstadoId);

                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public int Delete(int tipoMascotaId)
        {
            using (SqlConnection conn = _connectionFactory.CreateConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_EliminarTipoMascota", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TipoMascotaId", tipoMascotaId);

                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}