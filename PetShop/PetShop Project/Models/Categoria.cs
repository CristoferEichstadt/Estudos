using PetShop_Project.Models.Validação.Categoria;
using System.Collections.Generic;

namespace PetShop_Project.Models
{
    public class Categoria
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public IList<Subcategoria> Subcategorias { get; set; }
        public Categoria()
        {
            Subcategorias = new List<Subcategoria>();
        }

        public bool Valida()
        {
            return new ValidacaoNomeCategoria().Valida(Nome);
        }

    }
}