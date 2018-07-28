using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Alura.Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //var p1 = new Produto() { Nome = "Suco de laranja", Categoria = "Bebidas", PrecoUnitario = 8.99, Unidade = "Litros"};
            //var p2 = new Produto() { Nome = "Café", Categoria = "Bebidas", PrecoUnitario = 12.65, Unidade = "Gramas" };
            //var p3 = new Produto() { Nome = "Macarrão", Categoria = "Alimentos", PrecoUnitario = 4.50, Unidade = "Gramas" };

            //var promocaoDePascoa = new Promocao();
            //promocaoDePascoa.Descricao = "Feliz Páscoa";
            //promocaoDePascoa.DataInicio = DateTime.Now;
            //promocaoDePascoa.DataTermino = DateTime.Now.AddMonths(3);

            //promocaoDePascoa.IncluiProduto(p1);
            //promocaoDePascoa.IncluiProduto(p2);
            //promocaoDePascoa.IncluiProduto(p3);

            //using (var contexto = new LojaContext())
            //{
            //    contexto.Promocoes.Add(promocaoDePascoa);
            //    contexto.SaveChanges();

            //}

            //var fulano = new Cliente();
            //fulano.Nome = "Guilherme";
            //fulano.EnderecoDeEntrega = new Endereco()
            //{
            //    Numero = 362,
            //    Logradouro = "Rua Luiza Lucas",
            //    Complemento = "Casa",
            //    Bairro = "Salto do Norte",
            //    Cidade = "Blumenau"
            //};

            //using (var contexto = new LojaContext())
            //{
            //    contexto.Clientes.Add(fulano);
            //    contexto.SaveChanges();
            //}

            using (var contexto = new LojaContext())
            {
            
                var cliente = contexto
                    .Clientes
                    .Include(c => c.EnderecoDeEntrega)
                    .FirstOrDefault();

                Console.WriteLine($"Endereço de entrega: {cliente.EnderecoDeEntrega.Logradouro}");

                var produto = contexto
                    .Produtos
                    .Include(p => p.Compras)
                    .Where(p => p.Id == 1)
                    .FirstOrDefault();

                Console.WriteLine($"Mostrando as compras do produto {produto.Nome}");
                foreach (var item in produto.Compras)
                {
                    Console.WriteLine(item);
                }
            }
        }

        private static void ExibeProdutosDaPromocao(LojaContext contexto2)
        {
            var promocao = contexto2.Promocoes.Include(p => p.Produtos).ThenInclude(pp => pp.Produto).FirstOrDefault();
            Console.WriteLine("\nMotrando os produtos da promoção...");
            foreach (var item in promocao.Produtos)
            {
                Console.WriteLine(item.Produto);
            }
        }

        private static void IncluiPromocao(LojaContext contexto)
        {
            var promocao = new Promocao();
            promocao.Descricao = "Queima Total Janeiro 2017";
            promocao.DataInicio = new DateTime(2017, 1, 1);
            promocao.DataTermino = new DateTime(2017, 1, 31);

            var produtos = contexto
                .Produtos
                .Where(p => p.Categoria == "Bebidas")
                .ToList();

            foreach (var item in produtos)
            {
                promocao.IncluiProduto(item);
            }

            contexto.Promocoes.Add(promocao);
            contexto.SaveChanges();
        }
    }
}
