using Entities;
using PetMarket.DataAccess;
using PetMarket.Entities;
using System;
using System.Collections.Generic;

namespace PetMarket.BusinessLogic
{
    public class MarcaBL
    {
        private readonly MarcaRepository _repository;

        public MarcaBL(MarcaRepository repository)
        {
            _repository = repository;
        }

        public List<Marca> SelectAll()
        {
            try
            {
                return _repository.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Insert(Marca entity)
        {
            try
            {
                return _repository.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Delete(int id)
        {
            try
            {
                return _repository.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}