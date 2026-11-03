using Microsoft.Data.SqlClient;
using PetMarket.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace PetMarket.DataAccess
{
    public class MetodoPagoRepository
    {
        private readonly ConnectionFactory _connectionFactory;

        public MetodoPagoRepository(ConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public List<MetodoPago> SelectAll()
        {
            List<MetodoPago> result = new List<MetodoPago>();

            using (SqlConnection conn = _connectionFactory.CreateConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spMetodoPagoSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        while (dr.Read())
                        {
                            MetodoPago entity = new MetodoPago
                            {
                                MetodoPagoId = dr.GetInt32(dr.GetOrdinal("MetodoPagoId")),
                                Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                                Descripcion = dr.IsDBNull(dr.GetOrdinal("Descripcion")) ? string.Empty : dr.GetString(dr.GetOrdinal("Descripcion")),
                                EstadoId = dr.GetInt32(dr.GetOrdinal("EstadoId"))
                            };

                            result.Add(entity);
                        }
                    }
                }
            }

            return result;
        }

        public int Insert(MetodoPago entity)
        {
            int result = 0;

            using (SqlConnection conn = _connectionFactory.CreateConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spMetodoPagoInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", string.IsNullOrEmpty(entity.Descripcion) ? (object)DBNull.Value : entity.Descripcion);
                    cmd.Parameters.AddWithValue("@EstadoId", entity.EstadoId);

                    conn.Open();
                    object res = cmd.ExecuteScalar();
                    result = (res != null && res != DBNull.Value) ? Convert.ToInt32(res) : 0;
                }
            }

            return result;
        }

        public bool Update(MetodoPago entity)
        {
            int rowsAffected = 0;

            using (SqlConnection conn = _connectionFactory.CreateConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spMetodoPagoUpdate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MetodoPagoId", entity.MetodoPagoId);
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", string.IsNullOrEmpty(entity.Descripcion) ? (object)DBNull.Value : entity.Descripcion);
                    cmd.Parameters.AddWithValue("@EstadoId", entity.EstadoId);

                    conn.Open();
                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }

            return rowsAffected > 0;
        }

        public bool Delete(int metodoPagoId)
        {
            int rowsAffected = 0;

            using (SqlConnection conn = _connectionFactory.CreateConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spMetodoPagoDelete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MetodoPagoId", metodoPagoId);

                    conn.Open();
                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }

            return rowsAffected > 0;
        }
    }
}