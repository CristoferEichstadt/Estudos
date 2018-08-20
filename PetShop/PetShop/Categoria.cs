using System.Collections.Generic;

namespace PetShop
{
    public class Categoria
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public IList<Subcategoria> Subcategoria { get; set; }
    }
}