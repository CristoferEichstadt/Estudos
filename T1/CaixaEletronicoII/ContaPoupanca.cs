using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronicoII
{
    class ContaPoupanca : Conta, ITributavel //class ContaPoupança herda atributos|métodoss da class Conta.
    {
        public override void Saca(double valor)
        {
            if (valor > this.Saldo)
            {
                throw new SaldoInsuficienteException();
            }
            if (valor < 0)
            {
                throw new ArgumentException();
            }
            if (valor == 0)
            {
                throw new ValorIgualZeroException();
            }
            if (valor < this.Saldo && this.Titular.MaiorDeIdade())
            {
                this.Saldo -= valor + 0.1;
            }
        }        
        public double CalculaTributo()
        {
            return this.Saldo * 0.02;
        }
    }
}
