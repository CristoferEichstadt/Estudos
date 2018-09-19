using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetShop_Project.Models
{
    public class Categoria
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public IList<Subcategoria> Subcategorias { get; set; }
        public Categoria()
        {
            Subcategorias = new List<Subcategoria>();
        }
    }
}