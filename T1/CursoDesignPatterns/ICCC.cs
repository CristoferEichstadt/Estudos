using System;

namespace CursoDesignPatterns
{
    public class ICCC
    {
        public double Calcula(Orcamento orcamento)
        {
            if (Convert.ToDouble(orcamento) < 1000)
            {
                return (orcamento.Valor * 0.05);
            }
            else if ((Convert.ToDouble(orcamento) >= 1000) && Convert.ToDouble(orcamento) >= 3000)
            {
                return (orcamento.Valor * 0.07);
            }
            else
            {
                return ((orcamento.Valor * 0.08) + 30.0);
            }
        }
    }
}
