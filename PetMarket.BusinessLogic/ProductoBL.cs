using PetMarket.DataAccess;
using PetMarket.Entities;
using System;
using System.Collections.Generic;

namespace PetMarket.BusinessLogic
{
    public class ProductoBL
    {
        private readonly ProductoRepository _repository;

        public ProductoBL(ProductoRepository repository)
        {
            _repository = repository;
        }

        public List<Producto> SelectAll()
        {
            List<Producto> result = null;
            try
            {
                result = _repository.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public int Insert(Producto entity)
        {
            int result;
            try
            {
                result = _repository.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }
    }
}