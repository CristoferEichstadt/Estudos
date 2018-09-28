using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetShop_Project.Models
{
    public class Produto
    {
        public int Id { get; private set; }
        public Categoria Categoria { get; set; }
        public Subcategoria Subcategoria { get; set; }
        public int SubcategoriaId { get; set; }
        public int CategoriaId { get; set; }
        public DateTime DataInsercao { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public double ValorUnitario { get; set; }
        public double ValorCusto { get; set; }
        public double MargemLucro { get; set; }
        public bool Ativo { get; set; }
        public byte[] Imagem { get; set; }
        public IList<VendaItem> VendaItens { get; set; }
        public Produto()
        {
            VendaItens = new List<VendaItem>();
        }
    }
}