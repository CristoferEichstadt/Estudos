using Microsoft.EntityFrameworkCore;
using PetShop_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetShop_Project.DAO
{
    public class EnderecoDAO
    {

        public void Adiciona(Endereco endereco)
        {
            using (var context = new PetShopContext())
            {
                context.Enderecos.Add(endereco);
                context.SaveChanges();
            }
        }

        public IList<Endereco> Lista()
        {
            using (var contexto = new PetShopContext())
            {
                return contexto.Enderecos.ToList();
            }
        }

        public void Atualiza(Endereco endereco)
        {
            using (var contexto = new PetShopContext())
            {
                contexto.Entry(endereco).State = EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public Endereco BuscaPorId(int id)
        {
            using (var contexto = new PetShopContext())
            {
                return contexto.Enderecos.Find(id);
            }
        }

        public Endereco BuscaPorLogradouro(string logradouro)
        {
            using (var contexto = new PetShopContext())
            {
                return contexto.Enderecos.Where(c => c.Logradouro == logradouro).FirstOrDefault();
            }
        }

    }
}