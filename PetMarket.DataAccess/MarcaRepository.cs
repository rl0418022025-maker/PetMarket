using Entities;
using Microsoft.Data.SqlClient;
using PetMarket.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace PetMarket.DataAccess
{
    public class MarcaRepository
    {
        private readonly ConnectionFactory _connectionFactory;

        public MarcaRepository(ConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public List<Marca> SelectAll()
        {
            List<Marca> result = new List<Marca>();

            using (SqlConnection conn = _connectionFactory.CreateConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_ListarMarcas", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Marca entity = new Marca
                            {
                                MarcaId = Convert.ToInt32(dr["MarcaId"]),
                                Nombre = dr["Nombre"].ToString(),
                                Descripcion = dr["Descripcion"] != DBNull.Value ? dr["Descripcion"].ToString() : string.Empty,
                                EstadoId = Convert.ToInt32(dr["EstadoId"]),
                                NombreEstado = dr["NombreEstado"] != DBNull.Value ? dr["NombreEstado"].ToString() : string.Empty
                            };

                            result.Add(entity);
                        }
                    }
                }
            }

            return result;
        }

        public int Insert(Marca entity)
        {
            using (SqlConnection conn = _connectionFactory.CreateConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_InsertarMarca", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", string.IsNullOrWhiteSpace(entity.Descripcion) ? (object)DBNull.Value : entity.Descripcion);
                    cmd.Parameters.AddWithValue("@EstadoId", entity.EstadoId);

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    return rows != 0 ? 1 : 1;
                }
            }
        }

        public int Delete(int marcaId)
        {
            using (SqlConnection conn = _connectionFactory.CreateConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spMarcaDelete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MarcaId", marcaId);

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    return rows != 0 ? 1 : 1;
                }
            }
        }
    }
}