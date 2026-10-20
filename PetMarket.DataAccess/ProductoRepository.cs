using Microsoft.Data.SqlClient;
using PetMarket.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace PetMarket.DataAccess
{
    public class ProductoRepository
    {
        private readonly ConnectionFactory _connectionFactory;

        public ProductoRepository(ConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public List<Producto> SelectAll()
        {
            List<Producto> result = null;

            using (SqlConnection conn = _connectionFactory.CreateConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spProductoSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        result = new List<Producto>();

                        while (dr.Read())
                        {
                            Producto entity = new Producto();
                            entity.ProductoId = dr.GetInt32(0);
                            entity.Nombre = dr.GetString(1);
                            entity.Precio = dr.GetDecimal(2);
                            entity.Stock = dr.GetInt32(3);
                            entity.CategoriaId = dr.GetInt32(4);
                            entity.MarcaId = dr.GetInt32(5);
                            entity.EstadoId = dr.GetInt32(6);

                            result.Add(entity);
                        }
                    }
                }
            }

            return result;
        }

        public int Insert(Producto entity)
        {
            int result = 0;

            using (SqlConnection conn = _connectionFactory.CreateConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spProductoInsert", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", entity.Nombre);
                    cmd.Parameters.AddWithValue("@Precio", entity.Precio);
                    cmd.Parameters.AddWithValue("@Stock", entity.Stock);
                    cmd.Parameters.AddWithValue("@CategoriaId", entity.CategoriaId);
                    cmd.Parameters.AddWithValue("@MarcaId", entity.MarcaId);
                    cmd.Parameters.AddWithValue("@EstadoId", entity.EstadoId);

                    conn.Open();
                    result = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

            return result;
        }
    }
}
