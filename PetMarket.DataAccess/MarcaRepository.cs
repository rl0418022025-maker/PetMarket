using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using PetMarket.Entities;

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
            var lista = new List<Marca>();
            using (var connection = _connectionFactory.CreateConnection())
            {
                using (var command = new SqlCommand("spMarcaSelectAll", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        int idOrd = reader.GetOrdinal("MarcaId");
                        int nomOrd = reader.GetOrdinal("Nombre");
                        int descOrd = reader.GetOrdinal("Descripcion");
                        int estOrd = reader.GetOrdinal("EstadoId");
                        int nomEstOrd = reader.GetOrdinal("NombreEstado");

                        while (reader.Read())
                        {
                            lista.Add(new Marca
                            {
                                MarcaId = reader.GetInt32(idOrd),
                                Nombre = reader.GetString(nomOrd),
                                Descripcion = reader.IsDBNull(descOrd) ? string.Empty : reader.GetString(descOrd),
                                EstadoId = reader.GetInt32(estOrd),
                                NombreEstado = reader.GetString(nomEstOrd)
                            });
                        }
                    }
                }
            }
            return lista;
        }

        public int Insert(Marca marca)
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                using (var command = new SqlCommand("spMarcaInsert", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Nombre", marca.Nombre);
                    command.Parameters.AddWithValue("@Descripcion", (object)marca.Descripcion ?? DBNull.Value);
                    command.Parameters.AddWithValue("@EstadoId", marca.EstadoId);

                    connection.Open();
                    var result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
        }

        public bool Update(Marca marca)
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                using (var command = new SqlCommand("spMarcaUpdate", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MarcaId", marca.MarcaId);
                    command.Parameters.AddWithValue("@Nombre", marca.Nombre);
                    command.Parameters.AddWithValue("@Descripcion", (object)marca.Descripcion ?? DBNull.Value);
                    command.Parameters.AddWithValue("@EstadoId", marca.EstadoId);

                    connection.Open();
                    int filas = command.ExecuteNonQuery();
                    return filas > 0;
                }
            }
        }

        public int Delete(int marcaId)
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                using (var command = new SqlCommand("spMarcaDelete", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MarcaId", marcaId);

                    connection.Open();
                    int filas = command.ExecuteNonQuery();
                    return filas;
                }
            }
        }
    }
}