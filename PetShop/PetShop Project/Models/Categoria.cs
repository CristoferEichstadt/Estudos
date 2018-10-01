using PetShop_Project.Models.Validação.Categoria;
using System.Collections.Generic;

namespace PetShop_Project.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }

        public bool Valida()
        {
            return new ValidacaoNomeCategoria().Valida(Nome);
        }

    }
}