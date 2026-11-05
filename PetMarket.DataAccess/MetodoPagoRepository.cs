using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using PetMarket.Entities;

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
            var lista = new List<MetodoPago>();
            using (var connection = _connectionFactory.CreateConnection())
            {
                using (var command = new SqlCommand("spMetodoPagoSelectAll", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        int idOrd = reader.GetOrdinal("MetodoPagoId");
                        int nomOrd = reader.GetOrdinal("Nombre");
                        int descOrd = reader.GetOrdinal("Descripcion");
                        int estOrd = reader.GetOrdinal("EstadoId");

                        while (reader.Read())
                        {
                            lista.Add(new MetodoPago
                            {
                                MetodoPagoId = reader.GetInt32(idOrd),
                                Nombre = reader.GetString(nomOrd),
                                Descripcion = reader.IsDBNull(descOrd) ? string.Empty : reader.GetString(descOrd),
                                EstadoId = reader.GetInt32(estOrd)
                            });
                        }
                    }
                }
            }
            return lista;
        }

        public int Insert(MetodoPago metodoPago)
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                using (var command = new SqlCommand("spMetodoPagoInsert", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Nombre", metodoPago.Nombre);
                    command.Parameters.AddWithValue("@Descripcion", (object)metodoPago.Descripcion ?? DBNull.Value);
                    command.Parameters.AddWithValue("@EstadoId", metodoPago.EstadoId);

                    connection.Open();
                    var result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
        }

        public bool Update(MetodoPago metodoPago)
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                using (var command = new SqlCommand("spMetodoPagoUpdate", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MetodoPagoId", metodoPago.MetodoPagoId);
                    command.Parameters.AddWithValue("@Nombre", metodoPago.Nombre);
                    command.Parameters.AddWithValue("@Descripcion", (object)metodoPago.Descripcion ?? DBNull.Value);
                    command.Parameters.AddWithValue("@EstadoId", metodoPago.EstadoId);

                    connection.Open();
                    int filas = command.ExecuteNonQuery();
                    return filas > 0;
                }
            }
        }

        public bool Delete(int metodoPagoId)
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                using (var command = new SqlCommand("spMetodoPagoDelete", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MetodoPagoId", metodoPagoId);

                    connection.Open();
                    int filas = command.ExecuteNonQuery();
                    return filas > 0;
                }
            }
        }
    }
}