using PetShop_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetShop_Project.DAO
{
    public class PessoaDAO
    {
        public void Adiciona(Pessoa pessoa)
        {
            using (var context = new PetShopContext())
            {
                context.Pessoas.Add(pessoa);
                context.SaveChanges();
            }
        }

        public IList<Pessoa> Lista()
        {
            using (var contexto = new PetShopContext())
            {
                return contexto.Pessoas.ToList();
            }
        }

        public Pessoa BuscaPorId(int id)
        {
            using (var contexto = new PetShopContext())
            {
                return contexto.Pessoas.Find(id);
            }
        }

        //public void Atualiza(Pessoa pessoa)
        //{
        //    using (var contexto = new PetShopContext())
        //    {
        //        contexto.Entry(pessoa).State = System.Data.Entity.EntityState.Modified;
        //        contexto.SaveChanges();
        //    }
        //}

        public Pessoa Busca(string nome, string cpfCnpj)
        {
            using (var contexto = new PetShopContext())
            {
                return contexto.Pessoas.FirstOrDefault(p => p.Nome == nome && p.CpfCnpj == cpfCnpj);
            }
        }
    }
}

