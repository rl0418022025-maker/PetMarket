using System;
using System.Collections.Generic;
using PetMarket.DataAccess;
using PetMarket.Entities;

namespace PetMarket.BusinessLogic
{
    public class CategoriaBL
    {
        private readonly CategoriaRepository _categoriaRepository;

        public CategoriaBL(CategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public List<Categoria> ListarCategorias()
        {
            return _categoriaRepository.Obtenertodas();
        }

        public bool GuardarCategoria(Categoria categoria)
        {
            if (string.IsNullOrWhiteSpace(categoria.Nombre))
            {
                throw new ArgumentException("El nombre de la categoría es obligatorio.");
            }

            if (categoria.EstadoId <= 0)
            {
                categoria.EstadoId = 1; // 1 = Activo según la BD
            }

            return _categoriaRepository.Insertar(categoria);
        }
    }
}