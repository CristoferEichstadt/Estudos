using CursoDesignPatterns_II.Cap2;
using CursoDesignPatterns_II.Cap3;
using CursoDesignPatterns_II.Cap4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns_II
{
    class Program
    {
        static void Main(string[] args)
        {
            IExpressao esquerda = new Soma(new Numero(1), new Numero(10));
            IExpressao direita = new Subtracao(new Numero(20), new Numero(10));
            IExpressao soma = new Soma(esquerda, direita);

            Console.WriteLine(soma.Avalia());

        }

    }
}
