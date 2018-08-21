using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetShop_Project.Models
{
    public class Subcategoria
    {
        public int Id { get; private set; }
        public Categoria Categoria { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
    }
}