using System.Collections.Generic;
using PetMarket.Entities;
using PetMarket.DataAccess;

namespace PetMarket.BusinessLogic
{
    public class EmpleadoBL
    {
        private readonly EmpleadoRepository _empleadoRepository;

        public EmpleadoBL(EmpleadoRepository empleadoRepository)
        {
            _empleadoRepository = empleadoRepository;
        }

        public List<Empleado> SelectAll()
        {
            return _empleadoRepository.SelectAll();
        }

        public int Insert(Empleado empleado)
        {
            return _empleadoRepository.Insert(empleado);
        }

        public bool Update(Empleado empleado)
        {
            return _empleadoRepository.Update(empleado);
        }

        public bool Delete(int empleadoId)
        {
            return _empleadoRepository.Delete(empleadoId);
        }
    }
}