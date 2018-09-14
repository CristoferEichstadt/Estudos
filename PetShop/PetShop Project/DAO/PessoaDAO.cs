using PetShop_Project.Models;
using Microsoft.EntityFrameworkCore;
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

        public void Atualiza(Pessoa pessoa)
        {
            using (var contexto = new PetShopContext())
            {
                contexto.Entry(pessoa).State = EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public bool BuscaPorCpfCnpj(string cpfCnpj)
        {
            using (var contexto = new PetShopContext())
            {
                return contexto.Pessoas.Where(p => p.CpfCnpj == cpfCnpj).FirstOrDefault() != null;
            }
        }

        public Pessoa BuscaPorUsuario(int usuarioId)
        {
            using (var contexto = new PetShopContext())
            {
                return contexto.Usuarios.Include(u => u.Pessoa).Where(u => u.Id == usuarioId).FirstOrDefault().Pessoa;
            }
        }
    }
}

