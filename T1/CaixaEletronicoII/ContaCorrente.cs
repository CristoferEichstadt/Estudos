using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronicoII
{
    class ContaCorrente : Conta
    {
        public override bool Saca(double valor)
        {
            if (valor > this.Saldo || valor <= 0)
            {
                return false;
            }
            else
            {
                if (this.Titular.MaiorDeIdade())
                {
                    this.Saldo -= valor;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static int TotalDeContasCorrentes { get; private set; } //vai contar quantas contas tem. Static diz que é da classe, e não um atributo de cada conta criada, assim vai contar quantas contas foram criadas no total.

        public ContaCorrente(double saldo, int Numero)
        {
            this.Saldo = saldo;
            this.numero = Numero;
            ContaCorrente.TotalDeContasCorrentes++; //cada vez que criar uma conta corrente, ela vai somar no contador
        }
    }
}
