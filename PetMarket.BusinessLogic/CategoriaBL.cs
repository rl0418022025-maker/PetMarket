using System.Collections.Generic;
using PetMarket.Entities;
using PetMarket.DataAccess;

namespace PetMarket.BusinessLogic
{
    public class CategoriaBL
    {
        private readonly CategoriaRepository _categoriaRepository;

        public CategoriaBL(CategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public List<Categoria> SelectAll()
        {
            return _categoriaRepository.SelectAll();
        }

        public int Insert(Categoria categoria)
        {
            return _categoriaRepository.Insert(categoria);
        }

        public bool Update(Categoria categoria)
        {
            return _categoriaRepository.Update(categoria);
        }

        public int Delete(int categoriaId)
        {
            return _categoriaRepository.Delete(categoriaId);
        }
    }
}