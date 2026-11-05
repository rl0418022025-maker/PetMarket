using PetMarket.DataAccess;
using PetMarket.Entities;
using System.Collections.Generic;

namespace PetMarket.BusinessLogic
{
    public class ProductoBL
    {
        private readonly ProductoRepository _productoRepository;

        public ProductoBL(ProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }

        public List<Producto> SelectAll()
        {
            return _productoRepository.SelectAll();
        }

        public int Insert(Producto producto)
        {
            return _productoRepository.Insert(producto);
        }

        public bool Update(Producto producto)
        {
            return _productoRepository.Update(producto);
        }

        public bool Delete(int productoId)
        {
            return _productoRepository.Delete(productoId);
        }
    }
}