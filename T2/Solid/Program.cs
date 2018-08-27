using Solid.Cap4;
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
            List<Boleto> boletos = new List<Boleto>();
            boletos.Add(new Boleto(200));
            boletos.Add(new Boleto(700));
            boletos.Add(new Boleto(500));

            Fatura fatura = new Fatura(1400, "Guilherme");

            ProcessadorDeBoletos pdb = new ProcessadorDeBoletos();
            pdb.Processa(boletos, fatura);

            Console.WriteLine(fatura.Pago);
            Console.ReadKey();
        }
    }
}
