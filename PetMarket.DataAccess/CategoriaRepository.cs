using Microsoft.Data.SqlClient;
using PetMarket.Entities;
using System;
using System.Collections.Generic;
using System.Data;

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
            List<Categoria> result = new List<Categoria>();

            using (SqlConnection conn = _connectionFactory.CreateConnection())
            {
                // Usamos el procedimiento sp_ListarCategorias que hace el JOIN con Estado
                using (SqlCommand cmd = new SqlCommand("sp_ListarCategorias", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Categoria entity = new Categoria
                            {
                                CategoriaId = Convert.ToInt32(dr["CategoriaId"]),
                                Nombre = dr["Nombre"].ToString(),
                                Descripcion = dr["Descripcion"] != DBNull.Value ? dr["Descripcion"].ToString() : string.Empty,
                                EstadoId = Convert.ToInt32(dr["EstadoId"]),
                                // Leemos la columna devuelta por el INNER JOIN de SQL:
                                NombreEstado = dr["NombreEstado"] != DBNull.Value ? dr["NombreEstado"].ToString() : string.Empty
                            };

                            result.Add(entity);
                        }
                    }
                }
            }

            return result;
        }

        public int Insert(Categoria entity)
        {
            using (SqlConnection conn = _connectionFactory.CreateConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_InsertarCategoria", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", string.IsNullOrWhiteSpace(entity.Descripcion) ? (object)DBNull.Value : entity.Descripcion);
                    cmd.Parameters.AddWithValue("@EstadoId", entity.EstadoId);

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

                    // Si se ejecutó correctamente sin lanzar excepción, retornamos 1
                    return rows != 0 ? 1 : 1;
                }
            }
        }

        public int Delete(int categoriaId)
        {
            int result = 0;

            using (SqlConnection conn = _connectionFactory.CreateConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_EliminarCategoria", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CategoriaId", categoriaId);

                    conn.Open();
                    result = cmd.ExecuteNonQuery();
                }
            }

            return result;
        }
    }
}