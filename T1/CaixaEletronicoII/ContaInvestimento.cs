using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronicoII
{
    class ContaInvestimento : Conta, Tributavel
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
        public double CalculaTributo()
        {
            return this.Saldo * 0.03; //vai retornar o saldo com tributos
        }
    }
}
