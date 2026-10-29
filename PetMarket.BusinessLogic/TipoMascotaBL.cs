using PetMarket.DataAccess;
using PetMarket.Entities;
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

        public List<TipoMascota> SelectAll() => _repository.SelectAll();

        public int Insert(TipoMascota entity) => _repository.Insert(entity);

        public int Delete(int tipoMascotaId) => _repository.Delete(tipoMascotaId);
    }
}