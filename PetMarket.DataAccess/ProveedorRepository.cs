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
            List<Proveedor> result = new List<Proveedor>();

            using (SqlConnection conn = _connectionFactory.CreateConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spProveedorSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        while (dr.Read())
                        {
                            Proveedor entity = new Proveedor
                            {
                                ProveedorId = dr.GetInt32(0),
                                Nombre = dr.GetString(1),
                                Telefono = dr.IsDBNull(2) ? string.Empty : dr.GetString(2),
                                Correo = dr.IsDBNull(3) ? string.Empty : dr.GetString(3),
                                Direccion = dr.IsDBNull(4) ? string.Empty : dr.GetString(4)
                            };
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
                    cmd.Parameters.AddWithValue("@Telefono", string.IsNullOrEmpty(entity.Telefono) ? (object)DBNull.Value : entity.Telefono);
                    cmd.Parameters.AddWithValue("@Correo", string.IsNullOrEmpty(entity.Correo) ? (object)DBNull.Value : entity.Correo);
                    cmd.Parameters.AddWithValue("@Direccion", string.IsNullOrEmpty(entity.Direccion) ? (object)DBNull.Value : entity.Direccion);

                    conn.Open();
                    object scalar = cmd.ExecuteScalar();
                    if (scalar != null && scalar != DBNull.Value)
                    {
                        result = Convert.ToInt32(scalar);
                    }
                }
            }

            return result;
        }

        public bool Update(Proveedor entity)
        {
            int rowsAffected = 0;

            using (SqlConnection conn = _connectionFactory.CreateConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spProveedorUpdate", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ProveedorId", entity.ProveedorId);
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    cmd.Parameters.AddWithValue("@Telefono", string.IsNullOrEmpty(entity.Telefono) ? (object)DBNull.Value : entity.Telefono);
                    cmd.Parameters.AddWithValue("@Correo", string.IsNullOrEmpty(entity.Correo) ? (object)DBNull.Value : entity.Correo);
                    cmd.Parameters.AddWithValue("@Direccion", string.IsNullOrEmpty(entity.Direccion) ? (object)DBNull.Value : entity.Direccion);

                    conn.Open();
                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }

            return rowsAffected > 0;
        }

        public bool Delete(int id)
        {
            int rowsAffected = 0;

            using (SqlConnection conn = _connectionFactory.CreateConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spProveedorDelete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ProveedorId", id);

                    conn.Open();
                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }

            return rowsAffected > 0;
        }
    }
}