using Entities;
using Microsoft.Data.SqlClient;
using PetMarket.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace PetMarket.DataAccess
{
    public class ClienteRepository
    {
        private readonly ConnectionFactory _connectionFactory;

        public ClienteRepository(ConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public List<Cliente> SelectAll()
        {
            var lista = new List<Cliente>();
            using (var connection = _connectionFactory.CreateConnection())
            {
                using (var command = new SqlCommand("spClienteSelectAll", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Cliente
                            {
                                ClienteId = reader.GetInt32(reader.GetOrdinal("ClienteId")),
                                Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                                Apellido = reader.GetString(reader.GetOrdinal("Apellido")),
                                DUI = reader.GetString(reader.GetOrdinal("DUI")),
                                Telefono = reader.GetString(reader.GetOrdinal("Telefono")),
                                Correo = reader.IsDBNull(reader.GetOrdinal("Correo")) ? string.Empty : reader.GetString(reader.GetOrdinal("Correo")),
                                Direccion = reader.IsDBNull(reader.GetOrdinal("Direccion")) ? string.Empty : reader.GetString(reader.GetOrdinal("Direccion")),
                                EstadoId = reader.GetInt32(reader.GetOrdinal("EstadoId"))
                            });
                        }
                    }
                }
            }
            return lista;
        }

        public int Insert(Cliente cliente)
        {
            int nuevoId = 0;
            using (var connection = _connectionFactory.CreateConnection())
            {
                using (var command = new SqlCommand("spClienteInsert", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                    command.Parameters.AddWithValue("@Apellido", cliente.Apellido);
                    command.Parameters.AddWithValue("@DUI", cliente.DUI);
                    command.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                    command.Parameters.AddWithValue("@Correo", (object)cliente.Correo ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Direccion", (object)cliente.Direccion ?? DBNull.Value);
                    command.Parameters.AddWithValue("@EstadoId", cliente.EstadoId);

                    connection.Open();
                    var result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out var id))
                    {
                        nuevoId = id;
                    }
                }
            }
            return nuevoId;
        }

        public bool Update(Cliente cliente)
        {
            bool actualizado = false;
            using (var connection = _connectionFactory.CreateConnection())
            {
                using (var command = new SqlCommand("spClienteUpdate", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ClienteId", cliente.ClienteId);
                    command.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                    command.Parameters.AddWithValue("@Apellido", cliente.Apellido);
                    command.Parameters.AddWithValue("@DUI", cliente.DUI);
                    command.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                    command.Parameters.AddWithValue("@Correo", (object)cliente.Correo ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Direccion", (object)cliente.Direccion ?? DBNull.Value);
                    command.Parameters.AddWithValue("@EstadoId", cliente.EstadoId);

                    connection.Open();
                    int filasAfectadas = command.ExecuteNonQuery();
                    actualizado = filasAfectadas > 0;
                }
            }
            return actualizado;
        }

        public bool Delete(int clienteId)
        {
            bool eliminado = false;
            using (var connection = _connectionFactory.CreateConnection())
            {
                using (var command = new SqlCommand("spClienteDelete", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ClienteId", clienteId);

                    connection.Open();
                    int filasAfectadas = command.ExecuteNonQuery();
                    eliminado = filasAfectadas > 0;
                }
            }
            return eliminado;
        }
    }
}