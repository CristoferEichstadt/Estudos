using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetShop
{
    public class Subcategoria
    {
        public int Id { get; private set; }
        public Categoria Categoria { get; set; }
        public IList<Produto> Produto { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
    }
}