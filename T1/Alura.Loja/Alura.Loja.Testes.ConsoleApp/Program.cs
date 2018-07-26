using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args) =>
            //GravarUsandoEntity();
            //RecuperarProdutos();
            //ExcluirProduto();
            AtualizarProduto();

        private static void AtualizarProduto() //faz o UPDATE
        {
            //inclui um arquivo
            GravarUsandoEntity();
            RecuperarProdutos();

            //atualiza o produto
            using (var repo = new LojaContext())
            {
                Produto primeiro = repo.Produtos.First(); //pega um Produto e nao a lista toda
                primeiro.Nome = "EDITADO"; //edita 
                repo.Produtos.Update(primeiro); //faz o update
                repo.SaveChanges();
            }
            RecuperarProdutos();
        }

        private static void ExcluirProduto()
        {
            using (var repo = new LojaContext()) //faz o REMOVE
            {
                IList<Produto> produtos = repo.Produtos.ToList();
                foreach (var item in produtos)
                {
                    repo.Produtos.Remove(item);
                }
                repo.SaveChanges();
            }
        }

        private static void RecuperarProdutos()
        {
            using (var repo = new LojaContext()) //faz o SELECT
            {
                IList<Produto> produtos = repo.Produtos.ToList();

                foreach (var item in produtos)
                {
                    Console.WriteLine(item.Nome);
                }
            }
        }

        private static void GravarUsandoEntity() //faz o INSERT
        {
            Produto p = new Produto();
            p.Nome = "Harry Potter e a Ordem da Fênix";
            p.Categoria = "Livros";
            p.Preco = 19.89;

            using (var contexto = new LojaContext()) 
            {
                contexto.Produtos.Add(p);
                contexto.SaveChanges();
            }
        }
    }
}
