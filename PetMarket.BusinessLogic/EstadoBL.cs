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
            return _repository.SelectAll();
        }

        public int Insert(Estado entity)
        {
            if (string.IsNullOrWhiteSpace(entity.Nombre))
            {
                throw new ArgumentException("El nombre del estado es obligatorio.");
            }

            return _repository.Insert(entity);
        }
    }
}