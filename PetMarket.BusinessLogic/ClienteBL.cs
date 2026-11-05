using Entities;
using PetMarket.DataAccess;
using PetMarket.Entities;
using System.Collections.Generic;

namespace PetMarket.BusinessLogic
{
    public class ClienteBL
    {
        private readonly ClienteRepository _clienteRepository;

        public ClienteBL(ClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public List<Cliente> SelectAll()
        {
            return _clienteRepository.SelectAll();
        }

        public int Insert(Cliente cliente)
        {
            return _clienteRepository.Insert(cliente);
        }

        public bool Update(Cliente cliente)
        {
            return _clienteRepository.Update(cliente);
        }

        public bool Delete(int clienteId)
        {
            return _clienteRepository.Delete(clienteId);
        }
    }
}