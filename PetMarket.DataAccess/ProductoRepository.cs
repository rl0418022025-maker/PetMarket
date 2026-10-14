using System;
using System.Collections.Generic;
using System.Data;
using PetMarket.Entities;

namespace PetMarket.DataAccess
{
    public class ProductoRepository
    {
        private readonly ConnectionFactory _connectionFactory;

        public ProductoRepository(ConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public List<Producto> Obtenertodos()
        {
            var lista = new List<Producto>();

            using (var connection = _connectionFactory.CreateConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "sp_ListarProductos";
                    command.CommandType = CommandType.StoredProcedure;

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Producto
                            {
                                ProductoId = reader.GetInt32(reader.GetOrdinal("ProductoId")),
                                Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                                Descripcion = reader.IsDBNull(reader.GetOrdinal("Descripcion")) ? null : reader.GetString(reader.GetOrdinal("Descripcion")),
                                PrecioVenta = reader.GetDecimal(reader.GetOrdinal("PrecioVenta")),
                                StockMinimo = reader.GetInt32(reader.GetOrdinal("StockMinimo")),
                                CategoriaId = reader.GetInt32(reader.GetOrdinal("CategoriaId")),
                                Categoria = reader.GetString(reader.GetOrdinal("Categoria")),
                                MarcaId = reader.GetInt32(reader.GetOrdinal("MarcaId")),
                                Marca = reader.GetString(reader.GetOrdinal("Marca")),
                                EstadoId = reader.GetInt32(reader.GetOrdinal("EstadoId")),
                                Estado = reader.GetString(reader.GetOrdinal("Estado"))
                            });
                        }
                    }
                }
            }
            return lista;
        }

        public bool Insertar(Producto producto)
        {
            using (var connection = _connectionFactory.CreateConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "sp_InsertarProducto";
                    command.CommandType = CommandType.StoredProcedure;

                    var p1 = command.CreateParameter(); p1.ParameterName = "@Nombre"; p1.Value = producto.Nombre; command.Parameters.Add(p1);
                    var p2 = command.CreateParameter(); p2.ParameterName = "@Descripcion"; p2.Value = (object)producto.Descripcion ?? DBNull.Value; command.Parameters.Add(p2);
                    var p3 = command.CreateParameter(); p3.ParameterName = "@PrecioVenta"; p3.Value = producto.PrecioVenta; command.Parameters.Add(p3);
                    var p4 = command.CreateParameter(); p4.ParameterName = "@StockMinimo"; p4.Value = producto.StockMinimo; command.Parameters.Add(p4);
                    var p5 = command.CreateParameter(); p5.ParameterName = "@CategoriaId"; p5.Value = producto.CategoriaId; command.Parameters.Add(p5);
                    var p6 = command.CreateParameter(); p6.ParameterName = "@MarcaId"; p6.Value = producto.MarcaId; command.Parameters.Add(p6);
                    var p7 = command.CreateParameter(); p7.ParameterName = "@EstadoId"; p7.Value = producto.EstadoId; command.Parameters.Add(p7);

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
