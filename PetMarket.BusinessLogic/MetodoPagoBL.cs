
using PetMarket.DataAccess;
using PetMarket.Entities;
using System;
using System.Collections.Generic;

namespace PetMarket.BusinessLogic
{
    public class MetodoPagoBL
    {
        private readonly MetodoPagoRepository _repository;

        public MetodoPagoBL(MetodoPagoRepository repository)
        {
            _repository = repository;
        }

        public List<MetodoPago> SelectAll()
        {
            List<MetodoPago> result = null;
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

        public int Insert(MetodoPago entity)
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
