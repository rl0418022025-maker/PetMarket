using System.Collections.Generic;
using PetMarket.Entities;
using PetMarket.DataAccess;

namespace PetMarket.BusinessLogic
{
    public class RolBL
    {
        private readonly RolRepository _rolRepository;

        public RolBL(RolRepository rolRepository)
        {
            _rolRepository = rolRepository;
        }

        public List<Rol> SelectAll()
        {
            return _rolRepository.SelectAll();
        }

        public int Insert(Rol rol)
        {
            return _rolRepository.Insert(rol);
        }

        public bool Update(Rol rol)
        {
            return _rolRepository.Update(rol);
        }

        public bool Delete(int rolId)
        {
            return _rolRepository.Delete(rolId);
        }
    }
}