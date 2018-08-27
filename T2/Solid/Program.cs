using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            EnviadorDeEmail enviadorDeEmail = new EnviadorDeEmail();
            NotaFiscalDao nfDao = new NotaFiscalDao();
            IList<IAcaoAposGerarNota> acoes = new List<IAcaoAposGerarNota>();

            acoes.Add(new EnviadorDeEmail());
            acoes.Add(new NotaFiscalDao());
            GeradorDeNotaFiscal gnf = new GeradorDeNotaFiscal(acoes);
            Fatura fatura = new Fatura(200, "Guilherme Francisco");
            gnf.Gera(fatura);

            Console.ReadKey();
            Console.WriteLine();

        }
    }
}
