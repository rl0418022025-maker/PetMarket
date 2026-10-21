using Entities;
using PetMarket.DataAccess;
using PetMarket.Entities;
using System;
using System.Collections.Generic;

namespace PetMarket.BusinessLogic
{
    public class ClienteBL
    {
        private readonly ClienteRepository _repository;

        public ClienteBL(ClienteRepository repository)
        {
            _repository = repository;
        }

        public List<Cliente> SelectAll()
        {
            List<Cliente> result = null;
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

        public int Insert(Cliente entity)
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