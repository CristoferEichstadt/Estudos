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
        private List<Lance> maioresLances;
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
            PegaOsMaioresNo(leilao);
        }
        private void PegaOsMaioresNo(Leilao leilao)
        {
            maioresLances = new List<Lance>(leilao.Lances.OrderByDescending(x => x.Valor)); //pega os lances por ordem de valor
            maioresLances = maioresLances.GetRange(0, 3); //vai pegar os 3 primeiros valores
        }

        public List<Lance> TresMaiores { get { return maioresLances; } }
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
