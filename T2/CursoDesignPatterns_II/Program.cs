using CursoDesignPatterns_II.Cap2;
using CursoDesignPatterns_II.Cap3;
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

            var historico = new HistoricoContrato();
            var contrato = new Contrato(DateTime.Now, "Guilherme", TipoContrato.Novo);
            historico.Adiciona(contrato.SalvaEstado());

            contrato.Avanca();
            historico.Adiciona(contrato.SalvaEstado());

            contrato.Avanca();
            historico.Adiciona(contrato.SalvaEstado());

            Console.WriteLine(historico.Pega(0).Contrato.Tipo);

        }

    }
}
