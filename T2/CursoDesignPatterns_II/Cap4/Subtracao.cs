using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns_II.Cap4
{
    class Subtracao : IExpressao
    {
        public Subtracao(IExpressao esquerda, IExpressao direita)
        {
            Esquerda = esquerda;
            Direita = direita;
        }

        public int Avalia()
        {
            int valorEsquerda = Esquerda.Avalia();
            int valorDireita = Direita.Avalia();
            return valorEsquerda - valorDireita;
        }

        public IExpressao Esquerda { get; }
        public IExpressao Direita { get; }
    }
}
