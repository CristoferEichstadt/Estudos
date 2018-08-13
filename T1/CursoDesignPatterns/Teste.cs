using CursoDesignPatterns;
using System;

class Teste
{
    static void Main(string[] args)
    {
        Orcamento reforma = new Orcamento(500.0);

        IImposto novoImposto = new ICCC();
        Console.WriteLine(novoImposto.Calcula(reforma));
    }
}