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
            var lista = new List<Producto>();
            using (var connection = _connectionFactory.CreateConnection())
            {
                using (var command = new SqlCommand("spProductoSelectAll", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Producto
                            {
                                ProductoId = reader.GetInt32(reader.GetOrdinal("ProductoId")),
                                Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                                Descripcion = reader.IsDBNull(reader.GetOrdinal("Descripcion")) ? string.Empty : reader.GetString(reader.GetOrdinal("Descripcion")),
                                Precio = reader.GetDecimal(reader.GetOrdinal("Precio")),
                                Stock = reader.GetInt32(reader.GetOrdinal("Stock")),
                                CategoriaId = reader.GetInt32(reader.GetOrdinal("CategoriaId")),
                                MarcaId = reader.GetInt32(reader.GetOrdinal("MarcaId")),
                                EstadoId = reader.GetInt32(reader.GetOrdinal("EstadoId"))
                            });
                        }
                    }
                }
            }
            return lista;
        }

        public int Insert(Producto producto)
        {
            int nuevoId = 0;
            using (var connection = _connectionFactory.CreateConnection())
            {
                using (var command = new SqlCommand("spProductoInsert", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Nombre", producto.Nombre);
                    command.Parameters.AddWithValue("@Descripcion", (object)producto.Descripcion ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Precio", producto.Precio);
                    command.Parameters.AddWithValue("@Stock", producto.Stock);
                    command.Parameters.AddWithValue("@CategoriaId", producto.CategoriaId);
                    command.Parameters.AddWithValue("@MarcaId", producto.MarcaId);
                    command.Parameters.AddWithValue("@EstadoId", producto.EstadoId);

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

        public bool Update(Producto producto)
        {
            bool actualizado = false;
            using (var connection = _connectionFactory.CreateConnection())
            {
                using (var command = new SqlCommand("spProductoUpdate", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ProductoId", producto.ProductoId);
                    command.Parameters.AddWithValue("@Nombre", producto.Nombre);
                    command.Parameters.AddWithValue("@Descripcion", (object)producto.Descripcion ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Precio", producto.Precio);
                    command.Parameters.AddWithValue("@Stock", producto.Stock);
                    command.Parameters.AddWithValue("@CategoriaId", producto.CategoriaId);
                    command.Parameters.AddWithValue("@MarcaId", producto.MarcaId);
                    command.Parameters.AddWithValue("@EstadoId", producto.EstadoId);

                    connection.Open();
                    int filasAfectadas = command.ExecuteNonQuery();
                    actualizado = filasAfectadas > 0;
                }
            }
            return actualizado;
        }

        public bool Delete(int productoId)
        {
            bool eliminado = false;
            using (var connection = _connectionFactory.CreateConnection())
            {
                using (var command = new SqlCommand("spProductoDelete", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ProductoId", productoId);

                    connection.Open();
                    int filasAfectadas = command.ExecuteNonQuery();
                    eliminado = filasAfectadas > 0;
                }
            }
            return eliminado;
        }
    }
}