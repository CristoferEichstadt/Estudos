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

    }
}