using System;

namespace PetShop
{
    public class Produto
    {
        public int Id { get; private set; }
        public Categoria Categoria { get; set; }
        public Subcategoria Subcategoria { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime DataInsercao { get; set; }
        public string Nome { get; set; }
        public string Detalhes { get; set; }
        public int Quantidade { get; set; }
        public double ValorUnitario { get; set; }
        public double ValorCusto { get; set; }
        public double MargemLucro { get; set; }
        public bool Ativo { get; set; }
        public byte[] Imagem { get; set; }
    }
}