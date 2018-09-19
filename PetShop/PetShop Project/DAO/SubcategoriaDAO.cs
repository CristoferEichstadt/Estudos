using Microsoft.EntityFrameworkCore;
using PetShop_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetShop_Project.DAO
{
    public class SubcategoriaDAO
    {

        public void Adiciona(Subcategoria subcategoria)
        {
            using (var context = new PetShopContext())
            {
                context.Subcategorias.Add(subcategoria);
                context.SaveChanges();
            }
        }

        public IList<Subcategoria> Lista()
        {
            using (var contexto = new PetShopContext())
            {
                return contexto.Subcategorias.ToList();
            }
        }

        public void Atualiza(Subcategoria subcategoria)
        {
            using (var contexto = new PetShopContext())
            {
                contexto.Entry(subcategoria).State = EntityState.Modified;
                contexto.SaveChanges();
            }
        }
        public Subcategoria BuscaPorId(int id)
        {
            using (var contexto = new PetShopContext())
            {
                return contexto.Subcategorias.Find(id);
            }
        }

        public Subcategoria BuscaPorNome(string nome)
        {
            using (var contexto = new PetShopContext())
            {
                return contexto.Subcategorias.Where(c => c.Nome == nome).FirstOrDefault();
            }
        }

    }
}