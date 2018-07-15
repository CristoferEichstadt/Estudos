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

        public ContaCorrente(double saldo, int Numero)
        {
            this.Saldo = saldo;
            this.numero = Numero;
        }
    }
}
