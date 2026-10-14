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

        public List<Categoria> Obtenertodas()
        {
            var lista = new List<Categoria>();

            using (var connection = _connectionFactory.CreateConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "sp_ListarCategorias";
                    command.CommandType = CommandType.StoredProcedure;

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Categoria
                            {
                                CategoriaId = reader.GetInt32(reader.GetOrdinal("CategoriaId")),
                                Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                                Descripcion = reader.IsDBNull(reader.GetOrdinal("Descripcion")) ? null : reader.GetString(reader.GetOrdinal("Descripcion")),
                                EstadoId = reader.GetInt32(reader.GetOrdinal("EstadoId")),
                                NombreEstado = reader.GetString(reader.GetOrdinal("NombreEstado"))
                            });
                        }
                    }
                }
            }
            return lista;
        }

        public bool Insertar(Categoria categoria)
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "sp_InsertarCategoria";
                    command.CommandType = CommandType.StoredProcedure;

                    var pNombre = command.CreateParameter();
                    pNombre.ParameterName = "@Nombre";
                    pNombre.Value = categoria.Nombre;
                    command.Parameters.Add(pNombre);

                    var pDesc = command.CreateParameter();
                    pDesc.ParameterName = "@Descripcion";
                    pDesc.Value = (object)categoria.Descripcion ?? DBNull.Value;
                    command.Parameters.Add(pDesc);

                    var pEstado = command.CreateParameter();
                    pEstado.ParameterName = "@EstadoId";
                    pEstado.Value = categoria.EstadoId;
                    command.Parameters.Add(pEstado);

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}