using Microsoft.EntityFrameworkCore;
using PetShop_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetShop_Project.DAO
{
    public class EstoqueDAO
    {

        public void Adiciona(Estoque estoque)
        {
            using (var context = new PetShopContext())
            {
                context.Estoque.Add(estoque);
                context.SaveChanges();
            }
        }
        public IList<Estoque> Lista()
        {
            using (var contexto = new PetShopContext())
            {
                return contexto.Estoque
                    .Include(e => e.UsuarioAlteracao)
                    .ThenInclude(u => u.Pessoa)
                    .ToList();
            }
        }

        public void Atualiza(Estoque estoque)
        {
            using (var contexto = new PetShopContext())
            {
                contexto.Estoque.Update(estoque);
                contexto.SaveChanges();
            }
        }

        public void Exclui(Estoque estoque)
        {
            using (var contexto = new PetShopContext())
            {
                contexto.Estoque.Remove(estoque);
                contexto.SaveChanges();
            }
        }

        public Estoque BuscaPorId(int id)
        {
            using (var contexto = new PetShopContext())
            {
                return contexto.Estoque
                    .Include(e => e.UsuarioAlteracao)
                    .ThenInclude(u => u.Pessoa)
                    .Include(e => e.Produto)
                    .ThenInclude(p => p.Categoria)
                    .Include(e => e.Produto)
                    .ThenInclude(p => p.Subcategoria)
                    .Where(e => e.Produto.Id == id)
                    .FirstOrDefault();
            }
        }

    }
}