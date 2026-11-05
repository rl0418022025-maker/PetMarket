using System.Collections.Generic;
using PetMarket.Entities;
using PetMarket.DataAccess;

namespace PetMarket.BusinessLogic
{
    public class MarcaBL
    {
        private readonly MarcaRepository _marcaRepository;

        public MarcaBL(MarcaRepository marcaRepository)
        {
            _marcaRepository = marcaRepository;
        }

        public List<Marca> SelectAll()
        {
            return _marcaRepository.SelectAll();
        }

        public int Insert(Marca marca)
        {
            return _marcaRepository.Insert(marca);
        }

        public bool Update(Marca marca)
        {
            return _marcaRepository.Update(marca);
        }

        public int Delete(int marcaId)
        {
            return _marcaRepository.Delete(marcaId);
        }
    }
}