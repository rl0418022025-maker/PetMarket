using PetMarket.DataAccess;
using PetMarket.Entities;
using System;
using System.Collections.Generic;

namespace PetMarket.BusinessLogic
{
    public class EstadoBL
    {
        private readonly EstadoRepository _repository;

        public EstadoBL(EstadoRepository repository)
        {
            _repository = repository;
        }

        public List<Estado> SelectAll()
        {
            List<Estado> result = null;
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
    }
}
