using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetShop_Project.Models
{
    public class VendaItem
    {

        public Venda Venda { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public int VendaId { get; set; }
        public int ProdutoId { get; set; }
    }
}