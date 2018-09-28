using PetShop_Project.Models.Validação.Subcategoria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetShop_Project.Models
{
    public class Subcategoria
    {
        public int Id { get; private set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public bool Valida()
        {
            return new ValidacaoNomeSubcategoria().Valida(Nome);
        }
    }
}