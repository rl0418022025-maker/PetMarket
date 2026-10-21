
using Microsoft.Data.SqlClient;
using PetMarket.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace PetMarket.DataAccess
{
    public class ProveedorRepository
    {
        private readonly ConnectionFactory _connectionFactory;

        public ProveedorRepository(ConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public List<Proveedor> SelectAll()
        {
            List<Proveedor> result = null;

            using (SqlConnection conn = _connectionFactory.CreateConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spProveedorSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        result = new List<Proveedor>();

                        while (dr.Read())
                        {
                            Proveedor entity = new Proveedor();
                            entity.ProveedorId = dr.GetInt32(0);
                            entity.Nombre = dr.GetString(1);
                            entity.Telefono = dr.GetString(2);
                            entity.Correo = dr.GetString(3);
                            entity.Direccion = dr.GetString(4);

                            result.Add(entity);
                        }
                    }
                }
            }

            return result;
        }

        public int Insert(Proveedor entity)
        {
            int result = 0;

            using (SqlConnection conn = _connectionFactory.CreateConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spProveedorInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    cmd.Parameters.AddWithValue("@Telefono", entity.Telefono);
                    cmd.Parameters.AddWithValue("@Correo", entity.Correo);
                    cmd.Parameters.AddWithValue("@Direccion", entity.Direccion);

                    conn.Open();
                    result = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

            return result;
        }
    }
}
