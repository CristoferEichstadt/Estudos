using NUnit.Framework;
using System;

namespace Caelum.Leilao
{
    [TestFixture]
    public class AvaliadorTest
    {
        [Test]
        public void DeveEntenderLancesEmOrdemCrescente()
        {
            //1a PARTE: CENÁRIO
            Usuario guilherme = new Usuario("Guilherme");
            Usuario joao = new Usuario("João");
            Usuario thamara = new Usuario("Thamara");

            var leilao = new Leilao("PS4 NOVO");
            leilao.Propoe(new Lance(thamara, 250));
            leilao.Propoe(new Lance(joao, 300));
            leilao.Propoe(new Lance(guilherme, 400));

            //2a PARTE: AÇÃO
            var leiloeiro = new Avaliador();
            leiloeiro.Avalia(leilao);

            //3a PARTE: VALIDAÇÃO
            double maiorEsperado = 400;
            double menorEsperado = 250;

            Assert.AreEqual(maiorEsperado, leiloeiro.MaiorLance);
            Assert.AreEqual(menorEsperado, leiloeiro.MenorLance);
        }
    }
}
