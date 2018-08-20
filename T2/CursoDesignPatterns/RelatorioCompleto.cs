using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class RelatorioCompleto : TemplateRelatorio
    {
        protected override void Cabecalho()
        {
            Console.WriteLine("Banco Itaú");
            Console.WriteLine("Rua São Paulo, 1567");
            Console.WriteLine("(47) 3333-0000");
        }

        protected override void Rodape()
        {
            Console.WriteLine("contato@itau.com.br");
            Console.WriteLine(DateTime.Now);
        }

        protected override void Corpo(IList<Conta> contas)
        {
            foreach (Conta c in contas)
            {
                Console.WriteLine(c.Titular + " -> " + c.Numero + " -> " + c.Agencia + " -> " + c.Saldo);
            }
        }
    }
}
