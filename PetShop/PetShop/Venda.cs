using System;

namespace PetShop
{
    public class Venda
    {
        public int Id { get; set; }
        public Pedido Pedido { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime DataVenda { get; set; }
    }
}