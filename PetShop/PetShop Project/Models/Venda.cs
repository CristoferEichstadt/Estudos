using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetShop_Project.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime DataVenda { get; set; }
        public IList<VendaItem> VendaItens { get; set; }
        public Venda()
        {
            VendaItens = new List<VendaItem>();
        }

    }
}