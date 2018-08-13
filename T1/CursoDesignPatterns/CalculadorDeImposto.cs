﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
