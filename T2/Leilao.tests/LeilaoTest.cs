using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caelum.Leilao
{
    [TestFixture]
    public class LeilaoTest
    {

        [Test]
        public void DeveReceberUmLance()
        {
            Leilao leilao = new CriadorDeLeilao().Para("Macbook Pro 15").Constroi();
            Assert.AreEqual(0, leilao.Lances.Count);

            leilao.Propoe(new Lance(new Usuario("Steve Jobs"), 2000));

            Assert.AreEqual(1, leilao.Lances.Count);
            Assert.AreEqual(2000.0, leilao.Lances[0].Valor, 0.00001);
        }

        [Test]
        public void DeveReceberVariosLances()
        {
            Leilao leilao = new CriadorDeLeilao()
                .Para("Macbook Pro 15")
                .Lance(new Usuario("Steve Jobs"), 2000)
                .Lance(new Usuario("Steve Wozniak"), 3000)
                .Constroi();

            Assert.AreEqual(2, leilao.Lances.Count);
            Assert.AreEqual(2000.0, leilao.Lances[0].Valor, 0.00001);
            Assert.AreEqual(3000.0, leilao.Lances[1].Valor, 0.00001);
        }

        [Test]
        public void NaoDeveAceitarDoisLancesSeguidosDoMesmoUsuario()
        {
            Usuario steveJobs = new Usuario("Steve Jobs");
            Leilao leilao = new CriadorDeLeilao()
                .Para("Macbook Pro 15")
                .Lance(steveJobs, 2000.0)
                .Lance(steveJobs, 3000.0)
                .Constroi();

            Assert.AreEqual(1, leilao.Lances.Count);
            Assert.AreEqual(2000.0, leilao.Lances[0].Valor, 0.00001);
        }

        [Test]
        public void NaoDeveAceitarMaisDoQue5LancesDeUmMesmoUsuario()
        {
            Usuario steveJobs = new Usuario("Steve Jobs");
            Usuario billGates = new Usuario("Bill Gates");

            Leilao leilao = new CriadorDeLeilao().Para("Macbook Pro 15")
                    .Lance(steveJobs, 2000)
                    .Lance(billGates, 3000)
                    .Lance(steveJobs, 4000)
                    .Lance(billGates, 5000)
                    .Lance(steveJobs, 6000)
                    .Lance(billGates, 7000)
                    .Lance(steveJobs, 8000)
                    .Lance(billGates, 9000)
                    .Lance(steveJobs, 10000)
                    .Lance(billGates, 11000)
                    .Lance(steveJobs, 12000)
                    .Constroi();

            Assert.AreEqual(10, leilao.Lances.Count);
            int ultimo = leilao.Lances.Count - 1;
            Assert.AreEqual(11000.0, leilao.Lances[ultimo].Valor, 0.00001);
        }
    }

    [TestFixture]
    public class AvaliadorTest
    {

        private Avaliador leiloeiro;
        private Usuario maria;
        private Usuario jose;
        private Usuario joao;

        [SetUp]
        public void SetUp()
        {
            this.leiloeiro = new Avaliador();
            this.joao = new Usuario("João");
            this.jose = new Usuario("José");
            this.maria = new Usuario("Maria");
        }

        [Test]
        public void DeveEntenderLancesEmOrdemCrescente()
        {

            Leilao leilao = new CriadorDeLeilao()
                .Para("Playstation 3 Novo")
                .Lance(joao, 250)
                .Lance(jose, 300)
                .Lance(maria, 400)
                .Constroi();

            leiloeiro.Avalia(leilao);

            Assert.AreEqual(400.0, leiloeiro.MaiorLance, 0.00001);
            Assert.AreEqual(250.0, leiloeiro.MenorLance, 0.00001);
        }

        [Test]
        public void DeveEntenderLeilaoComApenasUmLance()
        {
            Leilao leilao = new CriadorDeLeilao()
            .Para("Playstation 3 Novo")
            .Lance(joao, 1000)
            .Constroi();

            leiloeiro.Avalia(leilao);

            Assert.AreEqual(1000.0, leiloeiro.MaiorLance, 0.00001);
            Assert.AreEqual(1000.0, leiloeiro.MenorLance, 0.00001);
        }

        [Test]
        public void DeveEncontrarOsTresMaioresLances()
        {
            Leilao leilao = new CriadorDeLeilao()
                .Para("Playstation 3 Novo")
                .Lance(joao, 100)
                .Lance(maria, 200)
                .Lance(joao, 300)
                .Lance(maria, 400)
                .Constroi();

            leiloeiro.Avalia(leilao);

            var maiores = leiloeiro.TresMaiores;
            Assert.AreEqual(3, maiores.Count);
            Assert.AreEqual(400.0, maiores[0].Valor, 0.00001);
            Assert.AreEqual(300.0, maiores[1].Valor, 0.00001);
            Assert.AreEqual(200.0, maiores[2].Valor, 0.00001);
        }
    }
}
