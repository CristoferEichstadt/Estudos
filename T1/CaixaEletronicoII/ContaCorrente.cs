using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Benner.CaixaEletronicoII.Contas;

namespace Benner.CaixaEletronicoII
{
    public class ContaCorrente : Conta
    {
        public override void Saca(double valor)
        {
            if ((valor+0.1) <= this.Saldo && Titular.MaiorDeIdade() == true)
            {
                Console.WriteLine( "é maior de idade" );
                Console.WriteLine(Titular.MaiorDeIdade());
                this.Saldo -= valor + 0.1;
            }
            else if ((valor + 0.1) > this.Saldo)
            {
                throw new SaldoInsuficienteException();
            }
            else if ((valor + 0.1) < 0)
            {
                throw new ArgumentException();
            }
            else if ((valor + 0.1) == 0)
            {
                throw new ValorIgualZeroException();
            }
        }
        public static int TotalDeContasCorrentes { get; private set; }
    }
}
