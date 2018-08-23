using CursoDesignPatterns_II.Cap5;

namespace CursoDesignPatterns_II.Cap4
{
    public class Soma : IExpressao
    {
        public IExpressao Esquerda { get; private set; }
        public IExpressao Direita { get; private set; }
        public Soma(IExpressao esquerda, IExpressao direita)
        {
            Esquerda = esquerda;
            Direita = direita;
        }
        public int Avalia()
        {
            int valorEsquerda = Esquerda.Avalia();
            int valorDireita = Direita.Avalia();
            return valorEsquerda + valorDireita;
        }
        public void Aceita(ImpressoraVisitor impressora)
        {
            impressora.ImprimeSoma(this);
        }
    }
}