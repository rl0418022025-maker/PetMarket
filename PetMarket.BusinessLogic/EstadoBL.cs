using System.Collections.Generic;
using PetMarket.Entities;
using PetMarket.DataAccess;

namespace PetMarket.BusinessLogic
{
    public class EstadoBL
    {
        private readonly EstadoRepository _estadoRepository;

        public EstadoBL(EstadoRepository estadoRepository)
        {
            _estadoRepository = estadoRepository;
        }

        public List<Estado> SelectAll()
        {
            return _estadoRepository.SelectAll();
        }

        public int Insert(Estado estado)
        {
            return _estadoRepository.Insert(estado);
        }

        public bool Update(Estado estado)
        {
            return _estadoRepository.Update(estado);
        }

        public bool Delete(int estadoId)
        {
            return _estadoRepository.Delete(estadoId);
        }
    }
}