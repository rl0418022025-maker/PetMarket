using Entities;
using Microsoft.Data.SqlClient;
using PetMarket.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace PetMarket.DataAccess
{
    public class MascotaRepository
    {
        private readonly ConnectionFactory _connectionFactory;

        public MascotaRepository(ConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public List<Mascota> SelectAll()
        {
            var lista = new List<Mascota>();
            using (var connection = _connectionFactory.CreateConnection())
            {
                using (var command = new SqlCommand("spMascotaSelectAll", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Mascota
                            {
                                MascotaId = reader.GetInt32(reader.GetOrdinal("MascotaId")),
                                Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                                Especie = reader.IsDBNull(reader.GetOrdinal("Especie")) ? string.Empty : reader.GetString(reader.GetOrdinal("Especie")),
                                Edad = reader.IsDBNull(reader.GetOrdinal("Edad")) ? string.Empty : reader.GetString(reader.GetOrdinal("Edad")),
                                ClienteId = reader.GetInt32(reader.GetOrdinal("ClienteId")),
                                TipoMascotaId = reader.GetInt32(reader.GetOrdinal("TipoMascotaId")),
                                EstadoId = reader.GetInt32(reader.GetOrdinal("EstadoId"))
                            });
                        }
                    }
                }
            }
            return lista;
        }

        public int Insert(Mascota mascota)
        {
            int nuevoId = 0;
            using (var connection = _connectionFactory.CreateConnection())
            {
                using (var command = new SqlCommand("spMascotaInsert", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Nombre", mascota.Nombre);
                    command.Parameters.AddWithValue("@Especie", (object)mascota.Especie ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Edad", (object)mascota.Edad ?? DBNull.Value);
                    command.Parameters.AddWithValue("@ClienteId", mascota.ClienteId);
                    command.Parameters.AddWithValue("@TipoMascotaId", mascota.TipoMascotaId);
                    command.Parameters.AddWithValue("@EstadoId", mascota.EstadoId);

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

        public bool Update(Mascota mascota)
        {
            bool actualizado = false;
            using (var connection = _connectionFactory.CreateConnection())
            {
                using (var command = new SqlCommand("spMascotaUpdate", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MascotaId", mascota.MascotaId);
                    command.Parameters.AddWithValue("@Nombre", mascota.Nombre);
                    command.Parameters.AddWithValue("@Especie", (object)mascota.Especie ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Edad", (object)mascota.Edad ?? DBNull.Value);
                    command.Parameters.AddWithValue("@ClienteId", mascota.ClienteId);
                    command.Parameters.AddWithValue("@TipoMascotaId", mascota.TipoMascotaId);
                    command.Parameters.AddWithValue("@EstadoId", mascota.EstadoId);

                    connection.Open();
                    int filasAfectadas = command.ExecuteNonQuery();
                    actualizado = filasAfectadas > 0;
                }
            }
            return actualizado;
        }

        public bool Delete(int mascotaId)
        {
            bool eliminado = false;
            using (var connection = _connectionFactory.CreateConnection())
            {
                using (var command = new SqlCommand("spMascotaDelete", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MascotaId", mascotaId);

                    connection.Open();
                    int filasAfectadas = command.ExecuteNonQuery();
                    eliminado = filasAfectadas > 0;
                }
            }
            return eliminado;
        }
    }
}