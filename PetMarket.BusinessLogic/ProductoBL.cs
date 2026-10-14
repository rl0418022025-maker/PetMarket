using System;
using System.Collections.Generic;
using PetMarket.DataAccess;
using PetMarket.Entities;

namespace PetMarket.BusinessLogic
{
    public class ProductoBL
    {
        private readonly ProductoRepository _productoRepository;

        public ProductoBL(ProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }

        public List<Producto> ListarProductos()
        {
            return _productoRepository.Obtenertodos();
        }

        public bool GuardarProducto(Producto producto)
        {
            if (string.IsNullOrWhiteSpace(producto.Nombre))
            {
                throw new ArgumentException("El nombre del producto es obligatorio.");
            }

            if (producto.PrecioVenta <= 0)
            {
                throw new ArgumentException("El precio de venta debe ser mayor a cero.");
            }

            return _productoRepository.Insertar(producto);
        }
    }
}
