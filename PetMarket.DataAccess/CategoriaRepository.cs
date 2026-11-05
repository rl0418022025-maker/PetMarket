using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using PetMarket.Entities;

namespace PetMarket.DataAccess
{
    public class CategoriaRepository
    {
        private readonly ConnectionFactory _connectionFactory;

        public CategoriaRepository(ConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public List<Categoria> SelectAll()
        {
            var lista = new List<Categoria>();
            using (var connection = _connectionFactory.CreateConnection())
            {
                using (var command = new SqlCommand("spCategoriaSelectAll", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        int idOrd = reader.GetOrdinal("CategoriaId");
                        int nomOrd = reader.GetOrdinal("Nombre");
                        int descOrd = reader.GetOrdinal("Descripcion");
                        int estOrd = reader.GetOrdinal("EstadoId");
                        int nomEstOrd = reader.GetOrdinal("NombreEstado");

                        while (reader.Read())
                        {
                            lista.Add(new Categoria
                            {
                                CategoriaId = reader.GetInt32(idOrd),
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

        public int Insert(Categoria categoria)
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                using (var command = new SqlCommand("spCategoriaInsert", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Nombre", categoria.Nombre);
                    command.Parameters.AddWithValue("@Descripcion", (object)categoria.Descripcion ?? DBNull.Value);
                    command.Parameters.AddWithValue("@EstadoId", categoria.EstadoId);

                    connection.Open();
                    var result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
        }

        public bool Update(Categoria categoria)
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                using (var command = new SqlCommand("spCategoriaUpdate", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CategoriaId", categoria.CategoriaId);
                    command.Parameters.AddWithValue("@Nombre", categoria.Nombre);
                    command.Parameters.AddWithValue("@Descripcion", (object)categoria.Descripcion ?? DBNull.Value);
                    command.Parameters.AddWithValue("@EstadoId", categoria.EstadoId);

                    connection.Open();
                    int filas = command.ExecuteNonQuery();
                    return filas > 0;
                }
            }
        }

        public int Delete(int categoriaId)
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                using (var command = new SqlCommand("spCategoriaDelete", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CategoriaId", categoriaId);

                    connection.Open();
                    int filas = command.ExecuteNonQuery();
                    return filas;
                }
            }
        }
    }
}