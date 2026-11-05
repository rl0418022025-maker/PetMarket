using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using PetMarket.Entities;

namespace PetMarket.DataAccess
{
    public class EstadoRepository
    {
        private readonly ConnectionFactory _connectionFactory;

        public EstadoRepository(ConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public List<Estado> SelectAll()
        {
            var lista = new List<Estado>();
            using (var connection = _connectionFactory.CreateConnection())
            {
                using (var command = new SqlCommand("spEstadoSelectAll", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        int idOrd = reader.GetOrdinal("EstadoId");
                        int nomOrd = reader.GetOrdinal("Nombre");
                        int descOrd = reader.GetOrdinal("Descripcion");

                        while (reader.Read())
                        {
                            lista.Add(new Estado
                            {
                                EstadoId = reader.GetInt32(idOrd),
                                Nombre = reader.GetString(nomOrd),
                                Descripcion = reader.IsDBNull(descOrd) ? string.Empty : reader.GetString(descOrd)
                            });
                        }
                    }
                }
            }
            return lista;
        }

        public int Insert(Estado estado)
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                using (var command = new SqlCommand("spEstadoInsert", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Nombre", estado.Nombre);
                    command.Parameters.AddWithValue("@Descripcion", (object)estado.Descripcion ?? DBNull.Value);

                    connection.Open();
                    var result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
        }

        public bool Update(Estado estado)
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                using (var command = new SqlCommand("spEstadoUpdate", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@EstadoId", estado.EstadoId);
                    command.Parameters.AddWithValue("@Nombre", estado.Nombre);
                    command.Parameters.AddWithValue("@Descripcion", (object)estado.Descripcion ?? DBNull.Value);

                    connection.Open();
                    int filas = command.ExecuteNonQuery();
                    return filas > 0;
                }
            }
        }

        public bool Delete(int estadoId)
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                using (var command = new SqlCommand("spEstadoDelete", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@EstadoId", estadoId);

                    connection.Open();
                    int filas = command.ExecuteNonQuery();
                    return filas > 0;
                }
            }
        }
    }
}