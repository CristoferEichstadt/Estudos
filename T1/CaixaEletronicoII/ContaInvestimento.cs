using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Benner.CaixaEletronicoII.Contas;


namespace Benner.CaixaEletronicoII
{
    class ContaInvestimento : Conta, ITributavel
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
            if (valor < this.Saldo)
            {
                this.Saldo -= valor;
            }
        }

        public double CalculaTributo()
        {
            return this.Saldo * 0.03; //vai retornar o saldo com tributos
        }
    }
}
