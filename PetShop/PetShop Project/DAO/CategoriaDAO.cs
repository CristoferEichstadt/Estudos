using Microsoft.EntityFrameworkCore;
using PetShop_Project.Models;
using System.Collections.Generic;
using System.Linq;

namespace PetShop_Project.DAO
{
    public class CategoriaDAO
    {
        public void Adiciona(Categoria categoria)
        {
            using (var context = new PetShopContext())
            {
                context.Categorias.Add(categoria);
                context.SaveChanges();
            }
        }

        public IList<Categoria> Lista()
        {
            using (var contexto = new PetShopContext())
            {
                return contexto.Categorias.ToList();
            }
        }

        public void Atualiza(Categoria categoria)
        {
            using (var contexto = new PetShopContext())
            {
                contexto.Entry(categoria).State = EntityState.Modified;
                contexto.SaveChanges();
            }
        }
        public Categoria BuscaPorId(int id)
        {
            using (var contexto = new PetShopContext())
            {
                return contexto.Categorias.Find(id);
            }
        }

        public bool BuscaPorNome(string nome)
        {
            using (var contexto = new PetShopContext())
            {
                return contexto.Categorias.Where(c => c.Nome == nome).FirstOrDefault() != null;
            }
        }
    }
}