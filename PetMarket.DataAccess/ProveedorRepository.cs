using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using PetMarket.Entities;

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
            var lista = new List<Proveedor>();
            using (var connection = _connectionFactory.CreateConnection())
            {
                using (var command = new SqlCommand("spProveedorSelectAll", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        int idOrd = reader.GetOrdinal("ProveedorId");
                        int nomOrd = reader.GetOrdinal("Nombre");
                        int telOrd = reader.GetOrdinal("Telefono");
                        int corOrd = reader.GetOrdinal("Correo");
                        int dirOrd = reader.GetOrdinal("Direccion");
                        int estOrd = reader.GetOrdinal("EstadoId");

                        while (reader.Read())
                        {
                            lista.Add(new Proveedor
                            {
                                ProveedorId = reader.GetInt32(idOrd),
                                Nombre = reader.GetString(nomOrd),
                                Telefono = reader.IsDBNull(telOrd) ? string.Empty : reader.GetString(telOrd),
                                Correo = reader.IsDBNull(corOrd) ? string.Empty : reader.GetString(corOrd),
                                Direccion = reader.IsDBNull(dirOrd) ? string.Empty : reader.GetString(dirOrd),
                                EstadoId = reader.GetInt32(estOrd)
                            });
                        }
                    }
                }
            }
            return lista;
        }

        public int Insert(Proveedor proveedor)
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                using (var command = new SqlCommand("spProveedorInsert", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Nombre", proveedor.Nombre);
                    command.Parameters.AddWithValue("@Telefono", (object)proveedor.Telefono ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Correo", (object)proveedor.Correo ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Direccion", (object)proveedor.Direccion ?? DBNull.Value);
                    command.Parameters.AddWithValue("@EstadoId", proveedor.EstadoId);

                    connection.Open();
                    var result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
        }

        public bool Update(Proveedor proveedor)
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                using (var command = new SqlCommand("spProveedorUpdate", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ProveedorId", proveedor.ProveedorId);
                    command.Parameters.AddWithValue("@Nombre", proveedor.Nombre);
                    command.Parameters.AddWithValue("@Telefono", (object)proveedor.Telefono ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Correo", (object)proveedor.Correo ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Direccion", (object)proveedor.Direccion ?? DBNull.Value);
                    command.Parameters.AddWithValue("@EstadoId", proveedor.EstadoId);

                    connection.Open();
                    int filas = command.ExecuteNonQuery();
                    return filas > 0;
                }
            }
        }

        public bool Delete(int proveedorId)
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                using (var command = new SqlCommand("spProveedorDelete", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ProveedorId", proveedorId);

                    connection.Open();
                    int filas = command.ExecuteNonQuery();
                    return filas > 0;
                }
            }
        }
    }
}