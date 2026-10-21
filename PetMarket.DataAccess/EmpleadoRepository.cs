using Entities;
using Microsoft.Data.SqlClient;
using PetMarket.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace PetMarket.DataAccess
{
    public class EmpleadoRepository
    {
        private readonly ConnectionFactory _connectionFactory;

        public EmpleadoRepository(ConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public List<Empleado> SelectAll()
        {
            List<Empleado> result = null;

            using (SqlConnection conn = _connectionFactory.CreateConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spEmpleadoSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        result = new List<Empleado>();

                        while (dr.Read())
                        {
                            Empleado entity = new Empleado();
                            entity.EmpleadoId = dr.GetInt32(0);
                            entity.Nombre = dr.GetString(1);
                            entity.EstadoId = dr.GetInt32(2);

                            result.Add(entity);
                        }
                    }
                }
            }

            return result;
        }

        public int Insert(Empleado entity)
        {
            int result = 0;

            using (SqlConnection conn = _connectionFactory.CreateConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spEmpleadoInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    cmd.Parameters.AddWithValue("@EstadoId", entity.EstadoId);

                    conn.Open();
                    result = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

            return result;
        }
    }
}