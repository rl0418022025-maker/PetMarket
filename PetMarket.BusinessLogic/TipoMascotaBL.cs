using Entities;
using PetMarket.DataAccess;
using PetMarket.Entities;
using System;
using System.Collections.Generic;

namespace PetMarket.BusinessLogic
{
    public class TipoMascotaBL
    {
        private readonly TipoMascotaRepository _repository;

        public TipoMascotaBL(TipoMascotaRepository repository)
        {
            _repository = repository;
        }

        public List<TipoMascota> SelectAll()
        {
            List<TipoMascota> result = null;
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

        public int Insert(TipoMascota entity)
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