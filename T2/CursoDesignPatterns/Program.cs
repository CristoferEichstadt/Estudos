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

            //Imposto testeImposto = new ISS(new ICMS());

            //Orcamento orcamento = new Orcamento(500.0);

            //Console.WriteLine(testeImposto.Calcula(orcamento));

            NotaFiscalBuilder builder = new NotaFiscalBuilder();
            builder.AdicionaAcao(new Multiplicador(2));
            builder.AdicionaAcao(new Multiplicador(3));
            builder.AdicionaAcao(new Multiplicador(5.5));

            NotaFiscal notaFiscal = builder.ParaEmpresa("Caelum")
                .ComCnpj("123.456.789/0001-10")
                .ComItem(new Item("item 1", 100.0))
                .ComItem(new Item("item 2", 200.0))
                .ComItem(new Item("item 3", 300.0))
                .ComObservacoes("entregar notaFiscal pessoalmente")
                .NaDataAtual()
                .Constroi();
        }
    }
}
