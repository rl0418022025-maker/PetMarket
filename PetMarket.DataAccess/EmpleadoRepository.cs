using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using PetMarket.Entities;

namespace PetMarket.DataAccess
{
    public class EmpleadoRepository
    {
        private readonly ConnectionFactory _connectionFactory;

        public EmpleadoRepository(ConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public List<Empleado> SelectAll()
        {
            var lista = new List<Empleado>();
            using (var connection = _connectionFactory.CreateConnection())
            {
                using (var command = new SqlCommand("spEmpleadoSelectAll", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        int idOrd = reader.GetOrdinal("EmpleadoId");
                        int nomOrd = reader.GetOrdinal("Nombre");
                        int apeOrd = reader.GetOrdinal("Apellido");
                        int duiOrd = reader.GetOrdinal("DUI");
                        int telOrd = reader.GetOrdinal("Telefono");
                        int corOrd = reader.GetOrdinal("Correo");
                        int carOrd = reader.GetOrdinal("Cargo");
                        int estOrd = reader.GetOrdinal("EstadoId");

                        while (reader.Read())
                        {
                            lista.Add(new Empleado
                            {
                                EmpleadoId = reader.GetInt32(idOrd),
                                Nombre = reader.GetString(nomOrd),
                                Apellido = reader.GetString(apeOrd),
                                DUI = reader.IsDBNull(duiOrd) ? string.Empty : reader.GetString(duiOrd),
                                Telefono = reader.IsDBNull(telOrd) ? string.Empty : reader.GetString(telOrd),
                                Correo = reader.IsDBNull(corOrd) ? string.Empty : reader.GetString(corOrd),
                                Cargo = reader.IsDBNull(carOrd) ? string.Empty : reader.GetString(carOrd),
                                EstadoId = reader.GetInt32(estOrd)
                            });
                        }
                    }
                }
            }
            return lista;
        }

        public int Insert(Empleado empleado)
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                using (var command = new SqlCommand("spEmpleadoInsert", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Nombre", empleado.Nombre);
                    command.Parameters.AddWithValue("@Apellido", empleado.Apellido);
                    command.Parameters.AddWithValue("@DUI", (object)empleado.DUI ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Telefono", (object)empleado.Telefono ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Correo", (object)empleado.Correo ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Cargo", (object)empleado.Cargo ?? DBNull.Value);
                    command.Parameters.AddWithValue("@EstadoId", empleado.EstadoId);

                    connection.Open();
                    var result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
        }

        public bool Update(Empleado empleado)
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                using (var command = new SqlCommand("spEmpleadoUpdate", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@EmpleadoId", empleado.EmpleadoId);
                    command.Parameters.AddWithValue("@Nombre", empleado.Nombre);
                    command.Parameters.AddWithValue("@Apellido", empleado.Apellido);
                    command.Parameters.AddWithValue("@DUI", (object)empleado.DUI ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Telefono", (object)empleado.Telefono ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Correo", (object)empleado.Correo ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Cargo", (object)empleado.Cargo ?? DBNull.Value);
                    command.Parameters.AddWithValue("@EstadoId", empleado.EstadoId);

                    connection.Open();
                    int filas = command.ExecuteNonQuery();
                    return filas > 0;
                }
            }
        }

        public bool Delete(int empleadoId)
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                using (var command = new SqlCommand("spEmpleadoDelete", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@EmpleadoId", empleadoId);

                    connection.Open();
                    int filas = command.ExecuteNonQuery();
                    return filas > 0;
                }
            }
        }
    }
}