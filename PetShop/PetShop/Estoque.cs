using System;

namespace PetShop
{
    public class Estoque
    {
        public Produto Produto { get; set; }
        public DateTime DataAlteracao { get; set; }
        public string TipoMovimentacao {get;set;}
        public Usuario UsuarioAlteracao { get; set; }
    }
}