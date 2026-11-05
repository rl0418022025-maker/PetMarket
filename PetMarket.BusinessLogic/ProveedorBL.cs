using System.Collections.Generic;
using PetMarket.Entities;
using PetMarket.DataAccess;

namespace PetMarket.BusinessLogic
{
    public class ProveedorBL
    {
        private readonly ProveedorRepository _proveedorRepository;

        public ProveedorBL(ProveedorRepository proveedorRepository)
        {
            _proveedorRepository = proveedorRepository;
        }

        public List<Proveedor> SelectAll()
        {
            return _proveedorRepository.SelectAll();
        }

        public int Insert(Proveedor proveedor)
        {
            return _proveedorRepository.Insert(proveedor);
        }

        public bool Update(Proveedor proveedor)
        {
            return _proveedorRepository.Update(proveedor);
        }

        public bool Delete(int proveedorId)
        {
            return _proveedorRepository.Delete(proveedorId);
        }
    }
}