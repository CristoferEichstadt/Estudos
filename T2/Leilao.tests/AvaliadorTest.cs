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

        [Test]
        public void DeveRetornarMediaDosLances()
        {
            //
            var guilherme = new Usuario("Guilherme");
            var joao = new Usuario("João");
            var dylan = new Usuario("Dylan");
            var davi = new Usuario("Davi");
            var valter = new Usuario("Valter");

            var leilao = new Leilao("RANGE ROVER USADA");
            leilao.Propoe(new Lance(guilherme, 500));
            leilao.Propoe(new Lance(joao, 520));
            leilao.Propoe(new Lance(dylan, 450));
            leilao.Propoe(new Lance(davi, 630));
            leilao.Propoe(new Lance(valter, 670));

            //
            var leiloeiro = new Avaliador();
            leiloeiro.AvaliaMedia(leilao);

            //
            double mediaEsperada = 554;

            Assert.AreEqual(mediaEsperada, leiloeiro.MediaLance);

        }

        [Test]
        public void VerificaPalindromo()
        {
            //
            var palindromo = new Palindromo();

            var frase = "Socorram-me subi no onibus em Marrocos";
            var frase2 = "Anotaram a data da maratonaa";


            //
            var ehPalindromo = palindromo.EhPalindromo(frase);
            var naoEhPalindromo = palindromo.EhPalindromo(frase2);


            //
            Assert.IsTrue(ehPalindromo);
            Assert.IsFalse(naoEhPalindromo);

        }
    }
}
