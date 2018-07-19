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
            if (valor < this.Saldo && this.Titular.MaiorDeIdade())
            {
                this.Saldo -= valor + 0.1;
            }
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
        }
        public static int TotalDeContasCorrentes { get; private set; } //vai contar quantas contas tem. Static diz que é da classe, e não um atributo de cada conta criada, assim vai contar quantas contas foram criadas no total.

        //public ContaCorrente(double saldo, int numero)
        //{
        //    this.Saldo = saldo;
        //    this.Numero = numero;
        //    ContaCorrente.TotalDeContasCorrentes++; //cada vez que criar uma conta corrente, ela vai somar no contador
        //}
    }
}
