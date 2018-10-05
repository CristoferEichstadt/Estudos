using PetShop_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;

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
        public void AlternaAtivo(int id)
        {
            using (var context = new PetShopContext())
            {
                var produto = context.Produtos.Find(id);
                produto.Ativo = !produto.Ativo; //fazer o contrario do que já tem
                context.SaveChanges();
            }
        }
        public IList<Produto> Lista()
        {
            using (var contexto = new PetShopContext())
            {
                return contexto.Produtos.Include(p => p.Categoria).Include(p => p.Subcategoria).ToList();
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
                return contexto.Produtos
                    .Include(p => p.Categoria)
                    .Include(p => p.Subcategoria)
                    .Where(p => p.Id == id)
                    .FirstOrDefault();
            }
        }

        public bool BuscaPorNome(string nome)
        {
            using (var contexto = new PetShopContext())
            {
                return contexto.Produtos.Where(c => c.Nome == nome).FirstOrDefault() != null;
            }
        }

        public IList<Produto> BuscaPorSub(int id)
        {
            using (var contexto = new PetShopContext())
            {
                return contexto.Produtos
                    .Where(c => c.SubcategoriaId == id)
                    .Include(p => p.Subcategoria)
                    .Include(p => p.Categoria)
                    .ToList();
            }
        }

        public void Exclui(int id)
        {
            using (var contexto = new PetShopContext())
            {
                contexto.Produtos.Remove(contexto.Produtos.Find(id));
                contexto.SaveChanges();
            }
        }
    }
}