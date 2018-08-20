using System.Collections.Generic;

namespace PetShop
{
    public class Pedido
    {
        public int Id { get; set; }
        public IList<Produto> Produto { get; set; }
        public Estoque Estoque { get; set; }
    }
}