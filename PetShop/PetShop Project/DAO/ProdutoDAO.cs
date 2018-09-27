using PetShop_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetShop_Project.DAO
{
    public class ProdutoDAO
    {

        public void Adiciona(Produto produto)
        {
            using (var context = new PetShopContext())
            {
                context.Produtos.Add(produto);
                context.SaveChanges();
            }
        }

        public IList<Produto> Lista()
        {
            using (var contexto = new PetShopContext())
            {
                return contexto.Produtos.ToList();
            }
        }

        public void Atualiza(Produto produto)
        {
            using (var contexto = new PetShopContext())
            {
                contexto.Produtos.Update(produto);
                contexto.SaveChanges();
            }
        }
        public Produto BuscaPorId(int id)
        {
            using (var contexto = new PetShopContext())
            {
                return contexto.Produtos.Find(id);
            }
        }

        public Produto BuscaPorNome(string nome)
        {
            using (var contexto = new PetShopContext())
            {
                return contexto.Produtos.Where(c => c.Nome == nome).FirstOrDefault();
            }
        }
    }
}