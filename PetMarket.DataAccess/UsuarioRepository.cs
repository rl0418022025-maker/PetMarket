using Entities;
using Microsoft.Data.SqlClient;
using PetMarket.DataAccess;
using PetMarket.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace PetMarket.DataAccess
{
    public class UsuarioRepository
    {
        private readonly ConnectionFactory _connectionFactory;

        public UsuarioRepository(ConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public List<Usuario> SelectAll()
        {
            List<Usuario> result = null;

            using (SqlConnection conn = _connectionFactory.CreateConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spUsuarioSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        result = new List<Usuario>();

                        while (dr.Read())
                        {
                            Usuario entity = new Usuario();
                            entity.UsuarioId = dr.GetInt32(0);
                            entity.NombreUsuario = dr.GetString(1);
                            entity.EmpleadoId = dr.GetInt32(2);
                            entity.RolId = dr.GetInt32(2);

                            result.Add(entity);
                        }
                    }
                }
            }

            return result;
        }

        public int Insert(Usuario entity)
        {
            int result = 0;

            using (SqlConnection conn = _connectionFactory.CreateConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spUsuarioInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", entity.NombreUsuario);

                    conn.Open();
                    result = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

            return result;
        }
    }
}