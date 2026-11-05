using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using PetMarket.Entities;

namespace PetMarket.DataAccess
{
    public class TipoMascotaRepository
    {
        private readonly ConnectionFactory _connectionFactory;

        public TipoMascotaRepository(ConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public List<TipoMascota> SelectAll()
        {
            var lista = new List<TipoMascota>();
            using (var connection = _connectionFactory.CreateConnection())
            {
                using (var command = new SqlCommand("spTipoMascotaSelectAll", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        int idOrd = reader.GetOrdinal("TipoMascotaId");
                        int espOrd = reader.GetOrdinal("Especie");
                        int descOrd = reader.GetOrdinal("Descripcion");
                        int estOrd = reader.GetOrdinal("EstadoId");

                        while (reader.Read())
                        {
                            lista.Add(new TipoMascota
                            {
                                TipoMascotaId = reader.GetInt32(idOrd),
                                Especie = reader.GetString(espOrd),
                                Descripcion = reader.IsDBNull(descOrd) ? string.Empty : reader.GetString(descOrd),
                                EstadoId = reader.GetInt32(estOrd)
                            });
                        }
                    }
                }
            }
            return lista;
        }

        public int Insert(TipoMascota tipoMascota)
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                using (var command = new SqlCommand("spTipoMascotaInsert", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Especie", tipoMascota.Especie);
                    command.Parameters.AddWithValue("@Descripcion", (object)tipoMascota.Descripcion ?? DBNull.Value);
                    command.Parameters.AddWithValue("@EstadoId", tipoMascota.EstadoId);

                    connection.Open();
                    var result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
        }

        public bool Update(TipoMascota tipoMascota)
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                using (var command = new SqlCommand("spTipoMascotaUpdate", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@TipoMascotaId", tipoMascota.TipoMascotaId);
                    command.Parameters.AddWithValue("@Especie", tipoMascota.Especie);
                    command.Parameters.AddWithValue("@Descripcion", (object)tipoMascota.Descripcion ?? DBNull.Value);
                    command.Parameters.AddWithValue("@EstadoId", tipoMascota.EstadoId);

                    connection.Open();
                    int filas = command.ExecuteNonQuery();
                    return filas > 0;
                }
            }
        }

        public bool Delete(int tipoMascotaId)
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                using (var command = new SqlCommand("spTipoMascotaDelete", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@TipoMascotaId", tipoMascotaId);

                    connection.Open();
                    int filas = command.ExecuteNonQuery();
                    return filas > 0;
                }
            }
        }
    }
}