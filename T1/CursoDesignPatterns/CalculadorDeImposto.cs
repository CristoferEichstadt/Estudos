using System;

namespace CursoDesignPatterns
{
    class CalculadorDeImposto
    {
        public void RealizaCalculo(Orcamento orcamento, Imposto imposto)
        {
            Console.WriteLine(imposto.Calcula(orcamento));
        }
    }
}
