using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class RelatorioSimples : TemplateRelatorio
    {
        protected override void Cabecalho()
        {
            Console.WriteLine("Banco Itaú");
        }

        protected override void Rodape()
        {
            Console.WriteLine("(47) 3333-0000");
        }

        protected override void Corpo(IList<Conta> contas)
        {
            foreach (Conta c in contas)
            {
                Console.WriteLine(c.Titular + " -> " + c.Saldo);
            }
        }
    }
}
