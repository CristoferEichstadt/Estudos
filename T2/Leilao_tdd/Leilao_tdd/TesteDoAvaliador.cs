using System;

namespace Caelum.Leilao
{
    public class TesteDoAvaliador
    {
        static void Main(String[] args)
        {
            Usuario guilherme = new Usuario("Guilherme");
            Usuario joao = new Usuario("João");
            Usuario thamara = new Usuario("Thamara");

            var leilao = new Leilao("PS4 NOVO");
            leilao.Propoe(new Lance(joao, 300));
            leilao.Propoe(new Lance(guilherme, 400));
            leilao.Propoe(new Lance(thamara, 250));

            var leiloeiro = new Avaliador();
            leiloeiro.Avalia(leilao);

            Console.WriteLine(leiloeiro.MaiorLance);
            Console.WriteLine(leiloeiro.MenorLance);
            Console.ReadKey();
        }
    }
}
