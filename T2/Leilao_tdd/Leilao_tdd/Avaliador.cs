using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caelum.Leilao
{
    public class Avaliador
    {
        private double maiorDeTodos = Double.MinValue;
        private double menorDeTodos = Double.MaxValue;
        private double mediaDeTodos;
        public void Avalia(Leilao leilao)
        {
            foreach (var lance in leilao.Lances)
            {
                if (lance.Valor > maiorDeTodos)
                {
                    maiorDeTodos = lance.Valor;
                }
                if (lance.Valor < menorDeTodos)
                {
                    menorDeTodos = lance.Valor;
                }
            }
        }
        public void AvaliaMedia(Leilao leilao)
        {
            int qtdLances = leilao.Lances.Count;
            double valorTotalLances = 0;

            foreach (var lance in leilao.Lances)
            {
                valorTotalLances += lance.Valor;
            }
            mediaDeTodos = (valorTotalLances / qtdLances);
        }
        public double MediaLance { get { return mediaDeTodos; } }
        public double MaiorLance { get { return maiorDeTodos; } }
        public double MenorLance { get { return menorDeTodos; } }
    }
}
