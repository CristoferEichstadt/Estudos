using CursoDesignPatterns_II.Cap2;
using CursoDesignPatterns_II.Cap3;
using CursoDesignPatterns_II.Cap4;
using CursoDesignPatterns_II.Cap5;
using CursoDesignPatterns_II.Cap6;
using CursoDesignPatterns_II.Cap7;
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
            FilaDeTrabalho fila = new FilaDeTrabalho();
            Pedido pedido1 = new Pedido("Mauricio", 100.0);
            Pedido pedido2 = new Pedido("Guilherme", 200.0);
            fila.Adiciona(new PagaPedido(pedido1));
            fila.Adiciona(new PagaPedido(pedido2));

            fila.Adiciona(new FinalizaPedido(pedido1));

            fila.Processa();
        }
    }
}
