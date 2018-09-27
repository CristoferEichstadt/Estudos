using PetShop_Project.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace PetShop_Project.DAO
{
    public class UsuarioDAO
    {
        public void Adiciona(Usuario usuario)
        {
            using (var context = new PetShopContext())
            {
                context.Usuarios.Add(usuario);
                context.SaveChanges();
            }
        }

        public IList<Usuario> Lista()
        {
            using (var contexto = new PetShopContext())
            {
                return contexto.Usuarios.ToList();
            }
        }

        public Usuario BuscaPorId(int id)
        {
            using (var contexto = new PetShopContext())
            {
                return contexto.Usuarios.Find(id);
            }
        }

        public void Atualiza(Usuario usuario)
        {
            using (var contexto = new PetShopContext())
            {
                contexto.Usuarios.Update(usuario);
                contexto.SaveChanges();
            }
        }

        public Usuario Busca(string email, string senha)
        {
            using (var contexto = new PetShopContext())
            {
                return contexto.Usuarios
                    .Include(u => u.Pessoa).ThenInclude(p => p.Endereco)
                    .Include(u => u.Pessoa).ThenInclude(p => p.Contato)
                    .Where(u => u.Email == email && u.Senha == senha).FirstOrDefault();
            }
        }
    }
}

