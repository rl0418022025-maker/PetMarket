using Entities;
using PetMarket.DataAccess;
using PetMarket.Entities;
using System;
using System.Collections.Generic;

namespace PetMarket.BusinessLogic
{
    public class UsuarioBL
    {
        private readonly UsuarioRepository _repository;

        public UsuarioBL(UsuarioRepository repository)
        {
            _repository = repository;
        }

        public List<Usuario> SelectAll()
        {
            List<Usuario> result = null;
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

        public int Insert(Usuario entity)
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