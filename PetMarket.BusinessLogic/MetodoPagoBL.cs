using System.Collections.Generic;
using PetMarket.Entities;
using PetMarket.DataAccess;

namespace PetMarket.BusinessLogic
{
    public class MetodoPagoBL
    {
        private readonly MetodoPagoRepository _metodoPagoRepository;

        public MetodoPagoBL(MetodoPagoRepository metodoPagoRepository)
        {
            _metodoPagoRepository = metodoPagoRepository;
        }

        public List<MetodoPago> SelectAll()
        {
            return _metodoPagoRepository.SelectAll();
        }

        public int Insert(MetodoPago metodoPago)
        {
            return _metodoPagoRepository.Insert(metodoPago);
        }

        public bool Update(MetodoPago metodoPago)
        {
            return _metodoPagoRepository.Update(metodoPago);
        }

        public bool Delete(int metodoPagoId)
        {
            return _metodoPagoRepository.Delete(metodoPagoId);
        }
    }
}