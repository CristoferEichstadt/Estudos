﻿using Microsoft.EntityFrameworkCore;
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

        public void AlternaAtivo(int id)
        {
            using (var context = new PetShopContext())
            {
                var sub = context.Subcategorias.Find(id);
                sub.Ativo = !sub.Ativo;
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
        public IList<Subcategoria> ListaSubcategorias(int id)
        {
            using (var contexto = new PetShopContext())
            {
                return contexto.Subcategorias.Where(s => s.CategoriaId == id).ToList();
            }
        }

        public void Atualiza(Subcategoria subcategoria)
        {
            using (var contexto = new PetShopContext())
            {
                contexto.Subcategorias.Update(subcategoria);
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

        public bool BuscaPorNome(string nome)
        {
            using (var contexto = new PetShopContext())
            {
                return contexto.Subcategorias.Where(c => c.Nome == nome).FirstOrDefault() != null;
            }
        }

    }
}