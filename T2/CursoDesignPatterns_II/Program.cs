using CursoDesignPatterns_II.Cap2;
using CursoDesignPatterns_II.Cap3;
using CursoDesignPatterns_II.Cap4;
using CursoDesignPatterns_II.Cap5;
using CursoDesignPatterns_II.Cap6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns_II
{
    class Program
    {
        static void Main(string[] args)
        {
            IMensagem mensagem = new MensagemPorEmail("Guilherme");
            mensagem.Envia();
        }
    }
}
