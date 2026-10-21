
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
            List<MetodoPago> result = null;

            using (SqlConnection conn = _connectionFactory.CreateConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spMetodoPagoSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        result = new List<MetodoPago>();

                        while (dr.Read())
                        {
                            MetodoPago entity = new MetodoPago();
                            entity.MetodoPagoId = dr.GetInt32(0);
                            entity.Nombre = dr.GetString(1);
                            entity.Descripcion = dr.GetString(2);
                            entity.EstadoId = dr.GetInt32(3);

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
                    cmd.Parameters.AddWithValue("@Descripcion", entity.Descripcion);
                    cmd.Parameters.AddWithValue("@EstadoId", entity.EstadoId);

                    conn.Open();
                    result = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

            return result;
        }
    }
}
