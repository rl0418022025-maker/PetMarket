using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using PetMarket.Entities;

namespace PetMarket.DataAccess
{
    public class RolRepository
    {
        private readonly ConnectionFactory _connectionFactory;

        public RolRepository(ConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public List<Rol> SelectAll()
        {
            var lista = new List<Rol>();
            using (var connection = _connectionFactory.CreateConnection())
            {
                using (var command = new SqlCommand("spRolSelectAll", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        int idOrd = reader.GetOrdinal("RolId");
                        int nomOrd = reader.GetOrdinal("Nombre");
                        int descOrd = reader.GetOrdinal("Descripcion");
                        int estOrd = reader.GetOrdinal("EstadoId");

                        while (reader.Read())
                        {
                            lista.Add(new Rol
                            {
                                RolId = reader.GetInt32(idOrd),
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

        public int Insert(Rol rol)
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                using (var command = new SqlCommand("spRolInsert", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Nombre", rol.Nombre);
                    command.Parameters.AddWithValue("@Descripcion", (object)rol.Descripcion ?? DBNull.Value);
                    command.Parameters.AddWithValue("@EstadoId", rol.EstadoId);

                    connection.Open();
                    var result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
        }

        public bool Update(Rol rol)
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                using (var command = new SqlCommand("spRolUpdate", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@RolId", rol.RolId);
                    command.Parameters.AddWithValue("@Nombre", rol.Nombre);
                    command.Parameters.AddWithValue("@Descripcion", (object)rol.Descripcion ?? DBNull.Value);
                    command.Parameters.AddWithValue("@EstadoId", rol.EstadoId);

                    connection.Open();
                    int filas = command.ExecuteNonQuery();
                    return filas > 0;
                }
            }
        }

        public bool Delete(int rolId)
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                using (var command = new SqlCommand("spRolDelete", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@RolId", rolId);

                    connection.Open();
                    int filas = command.ExecuteNonQuery();
                    return filas > 0;
                }
            }
        }
    }
}