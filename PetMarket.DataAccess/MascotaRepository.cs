
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
            List<Mascota> result = null;

            using (SqlConnection conn = _connectionFactory.CreateConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spMascotaSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        result = new List<Mascota>();

                        while (dr.Read())
                        {
                            Mascota entity = new Mascota();
                            entity.MascotaId = dr.GetInt32(0);
                            entity.Nombre = dr.GetString(1);
                            entity.Edad = dr.GetString(2);
                            entity.ClienteId = dr.GetInt32(3);
                            entity.TipoMascotaId = dr.GetInt32(4);
                            entity.EstadoId = dr.GetInt32(5);

                            result.Add(entity);
                        }
                    }
                }
            }

            return result;
        }

        public int Insert(Mascota entity)
        {
            int result = 0;

            using (SqlConnection conn = _connectionFactory.CreateConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spMascotaInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    cmd.Parameters.AddWithValue("@Edad", entity.Edad);
                    cmd.Parameters.AddWithValue("@ClienteId", entity.ClienteId);
                    cmd.Parameters.AddWithValue("@TipoMascotaId", entity.TipoMascotaId);
                    cmd.Parameters.AddWithValue("@EstadoId", entity.EstadoId);

                    conn.Open();
                    result = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

            return result;
        }
    }
}
