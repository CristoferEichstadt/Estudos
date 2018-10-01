using System;

namespace PetShop_Project.Models
{
    public class Estoque
    {
        public int Id { get; set; }
        public Produto Produto { get; set; }
        public int? ProdutoId { get; set; }
        public int TipoMovimentacao { get; set; }
        public Usuario UsuarioAlteracao { get; set; }
        public int? UsuarioAlteracaoId { get; set; }
        public DateTime DataAlteracao { get; set; }
        public int Quantidade { get; set; }

    }
}