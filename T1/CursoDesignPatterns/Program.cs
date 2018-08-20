using System;

namespace CursoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //CalculadorDeDescontos calculador = new CalculadorDeDescontos();

            //Orcamento orcamento = new Orcamento(500.0);
            //orcamento.AdicionaItem(new Item("Caneta", 250.0));
            //orcamento.AdicionaItem(new Item("Lapis5", 250.0));
            //orcamento.AdicionaItem(new Item("Lapis4", 250.0));
            //orcamento.AdicionaItem(new Item("Lapis3", 250.0));
            //orcamento.AdicionaItem(new Item("Lapis2", 250.0));
            //orcamento.AdicionaItem(new Item("Lapis1", 250.0));

            //double desconto = calculador.Calcula(orcamento);
            //Console.WriteLine(desconto);
            //Console.ReadKey();

            Imposto testeImposto = new ISS(new ICMS());

            Orcamento orcamento = new Orcamento(500.0);

            Console.WriteLine(testeImposto.Calcula(orcamento));
        }
    }
}
