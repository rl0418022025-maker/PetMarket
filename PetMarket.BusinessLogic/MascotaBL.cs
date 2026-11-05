using Entities;
using PetMarket.DataAccess;
using PetMarket.Entities;
using System.Collections.Generic;

namespace PetMarket.BusinessLogic
{
    public class MascotaBL
    {
        private readonly MascotaRepository _mascotaRepository;

        public MascotaBL(MascotaRepository mascotaRepository)
        {
            _mascotaRepository = mascotaRepository;
        }

        public List<Mascota> SelectAll()
        {
            return _mascotaRepository.SelectAll();
        }

        public int Insert(Mascota mascota)
        {
            return _mascotaRepository.Insert(mascota);
        }

        public bool Update(Mascota mascota)
        {
            return _mascotaRepository.Update(mascota);
        }

        public bool Delete(int mascotaId)
        {
            return _mascotaRepository.Delete(mascotaId);
        }
    }
}