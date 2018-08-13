using System;

namespace CursoDesignPatterns
{
    class CalculadorDeImposto
    {
        public void RealizaCalculo(Orcamento orcamento, IImposto imposto)
        {
            Console.WriteLine(imposto.Calcula(orcamento));
        }
    }
}
