using NUnit.Framework;
using System;
using System.Collections.Generic;

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
        [Test]
        public void DeveEntenderLeilaoComApenasUmLance()
        {
            var guilherme = new Usuario("Guilherme");
            Leilao leilao = new Leilao("CAMARO AMARELO");

            leilao.Propoe(new Lance(guilherme, 1000.0));

            var avaliador = new Avaliador();
            avaliador.Avalia(leilao);

            Assert.AreEqual(1000, avaliador.MaiorLance, 0.0001);
            Assert.AreEqual(1000, avaliador.MenorLance, 0.0001);
        }

        [Test]
        public void DeveEncontrarOsTresMaioresLances()
        {
            var guilherme = new Usuario("Guilherme");
            var thamara = new Usuario("Thamara");
            var leilao = new Leilao("Mustang");

            leilao.Propoe(new Lance(guilherme, 500));
            leilao.Propoe(new Lance(thamara, 600));
            leilao.Propoe(new Lance(guilherme, 700));
            leilao.Propoe(new Lance(thamara, 800));
            leilao.Propoe(new Lance(guilherme, 900));
            leilao.Propoe(new Lance(thamara, 1000));
            leilao.Propoe(new Lance(guilherme, 1100));

            var leiloeiro = new Avaliador();
            leiloeiro.Avalia(leilao);

            var maiores = leiloeiro.TresMaiores;

            Assert.AreEqual(3, maiores.Count);
            Assert.AreEqual(1100, maiores[0].Valor, 0.0000001);
            Assert.AreEqual(1000, maiores[1].Valor, 0.0000001);
            Assert.AreEqual(900, maiores[2].Valor, 0.0000001);
        }

        [Test]
        public void DeveEncontrarMaiorEMenorRandomico()
        {
            var guilherme = new Usuario("Guilherme");
            var thamara = new Usuario("Thamara");
            var leilao = new Leilao("Mustang");

            leilao.Propoe(new Lance(guilherme, 500));
            leilao.Propoe(new Lance(thamara, 320));
            leilao.Propoe(new Lance(guilherme, 100));
            leilao.Propoe(new Lance(thamara, 500));
            leilao.Propoe(new Lance(guilherme, 700));
            leilao.Propoe(new Lance(thamara, 212));
            leilao.Propoe(new Lance(guilherme, 542));

            var leiloeiro = new Avaliador();
            leiloeiro.Avalia(leilao);

            Assert.AreEqual(100, leiloeiro.MenorLance);
            Assert.AreEqual(700, leiloeiro.MaiorLance);
        }

        [Test]
        public void DeveEntenderLancesEmOrdemDecrescente()
        {
            //
            var guilherme = new Usuario("Guilherme");
            var thamara = new Usuario("Thamara");
            var leilao = new Leilao("CAFETEIRA EXPRESSO");

            leilao.Propoe(new Lance(thamara, 500));
            leilao.Propoe(new Lance(guilherme, 400));
            leilao.Propoe(new Lance(thamara, 300));
            leilao.Propoe(new Lance(guilherme, 200));
            leilao.Propoe(new Lance(thamara, 100));

            //
            var leiloeiro = new Avaliador();
            leiloeiro.Avalia(leilao);

            //
            Assert.AreEqual(500, leiloeiro.MaiorLance);
            Assert.AreEqual(100, leiloeiro.MenorLance);
        }

        [Test]
        public void DeveEncontrarOsTresMaioresLancesEntreQuatro()
        {
            var guilherme = new Usuario("Guilherme");
            var thamara = new Usuario("Thamara");
            var leilao = new Leilao("CACHAÇA 51");

            leilao.Propoe(new Lance(thamara, 600));
            leilao.Propoe(new Lance(guilherme, 700));
            leilao.Propoe(new Lance(thamara, 800));
            leilao.Propoe(new Lance(guilherme, 1100));

            var leiloeiro = new Avaliador();
            leiloeiro.Avalia(leilao);

            var maiores = leiloeiro.TresMaiores;

            Assert.AreEqual(3, maiores.Count);
            Assert.AreEqual(1100, maiores[0].Valor, 0.000000001);
            Assert.AreEqual(800, maiores[1].Valor, 0.000000001);
            Assert.AreEqual(700, maiores[2].Valor, 0.000000001);
        }

        [Test]
        public void DeveEncontrarOsDoisMaioresLancesEntreDois()
        {
            var guilherme = new Usuario("Guilherme");
            var thamara = new Usuario("Thamara");
            var leilao = new Leilao("AP BEIRA MAR");

            leilao.Propoe(new Lance(thamara, 600));
            leilao.Propoe(new Lance(guilherme, 700));

            var leiloeiro = new Avaliador();
            leiloeiro.Avalia(leilao);

            var maiores = leiloeiro.TresMaiores;

            Assert.AreEqual(2, maiores.Count);
            Assert.AreEqual(700, maiores[0].Valor, 0.000000001);
            Assert.AreEqual(600, maiores[1].Valor, 0.000000001);
        }

        [Test]
        public void DeveRetornarListaVazia()
        {
            var guilherme = new Usuario("Guilherme");
            var thamara = new Usuario("Thamara");
            var leilao = new Leilao("VESTIDO NOIVA");

            var leiloeiro = new Avaliador();
            leiloeiro.Avalia(leilao);

            var maiores = leiloeiro.TresMaiores;

            Assert.AreEqual(0, maiores.Count);
        }

        [Test]
        public void DeveVerificarValorMaiorQueTrinta()
        {
            MatematicaMaluca matematica = new MatematicaMaluca();
            Assert.AreEqual(50 * 4, matematica.ContaMaluca(50));
        }

        [Test]
        public void DeveVerificarValorMaiorQueTrintaEMenorQueDez()
        {
            MatematicaMaluca matematica = new MatematicaMaluca();
            Assert.AreEqual(20 * 3, matematica.ContaMaluca(20));
        }

        [Test]
        public void DeveVerificarValorMenorQueDez()
        {
            MatematicaMaluca matematica = new MatematicaMaluca();
            Assert.AreEqual(5 * 2, matematica.ContaMaluca(5));
        }

        [Test]
        public void DeveSelecionarLancesEntre1000E3000()
        {
            Usuario joao = new Usuario("Joao");

            FiltroDeLances filtro = new FiltroDeLances();
            IList<Lance> resultado = filtro.Filtra(new List<Lance>() {
            new Lance(joao,2000),
            new Lance(joao,1000),
            new Lance(joao,3000),
            new Lance(joao, 800)});

            Assert.AreEqual(1, resultado.Count);
            Assert.AreEqual(2000, resultado[0].Valor, 0.00001);
        }

        [Test]
        public void DeveSelecionarLancesEntre500E700()
        {
            Usuario joao = new Usuario("Joao");

            FiltroDeLances filtro = new FiltroDeLances();
            IList<Lance> resultado = filtro.Filtra(new List<Lance>() {
            new Lance(joao,600),
            new Lance(joao,500),
            new Lance(joao,700),
            new Lance(joao, 800)});

            Assert.AreEqual(1, resultado.Count);
            Assert.AreEqual(600, resultado[0].Valor, 0.00001);
        }

        [Test]
        public void DeveSelecionarLancesMaioresQue5000()
        {
            Usuario guilherme = new Usuario("Guilherme");

            FiltroDeLances filtro = new FiltroDeLances();
            IList<Lance> resultado = filtro.Filtra(new List<Lance>() {
            new Lance(guilherme, 5023)});

            Assert.AreEqual(1, resultado.Count);
            Assert.AreEqual(5023, resultado[0].Valor, 0.0000001);

        }

        [Test]
        public void DeveEliminarMenoresQue500()
        {
            Usuario guilherme = new Usuario("Guilherme");

            FiltroDeLances filtro = new FiltroDeLances();
            IList<Lance> resultado = filtro.Filtra(new List<Lance>() {
            new Lance(guilherme,400),
            new Lance(guilherme, 300)});

            Assert.AreEqual(0, resultado.Count);
        }

        [Test]
        public void DeveEliminarEntre3000E5000()
        {
            Usuario guilherme = new Usuario("Guilherme");

            FiltroDeLances filtro = new FiltroDeLances();
            IList<Lance> resultado = filtro.Filtra(new List<Lance>() {
            new Lance(guilherme,4000),
            new Lance(guilherme, 3500)});

            Assert.AreEqual(0, resultado.Count);
        }
    }
}
