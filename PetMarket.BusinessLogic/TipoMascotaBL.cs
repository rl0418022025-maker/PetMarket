using System.Collections.Generic;
using PetMarket.Entities;
using PetMarket.DataAccess;

namespace PetMarket.BusinessLogic
{
    public class TipoMascotaBL
    {
        private readonly TipoMascotaRepository _tipoMascotaRepository;

        public TipoMascotaBL(TipoMascotaRepository tipoMascotaRepository)
        {
            _tipoMascotaRepository = tipoMascotaRepository;
        }

        public List<TipoMascota> SelectAll()
        {
            return _tipoMascotaRepository.SelectAll();
        }

        public int Insert(TipoMascota tipoMascota)
        {
            return _tipoMascotaRepository.Insert(tipoMascota);
        }

        public bool Update(TipoMascota tipoMascota)
        {
            return _tipoMascotaRepository.Update(tipoMascota);
        }

        public bool Delete(int tipoMascotaId)
        {
            return _tipoMascotaRepository.Delete(tipoMascotaId);
        }
    }
}