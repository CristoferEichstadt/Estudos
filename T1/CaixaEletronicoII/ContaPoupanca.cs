using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronicoII
{
    class ContaPoupanca : Conta //class ContaPoupança herda atributos|métodoss da class Conta.
    {
        public override bool Saca(double valor) //override = pode substituir método da class Conta 
        {
            if (valor > this.Saldo || valor <= 0)
            {
                return false;
            }
            else
            {
                if (this.Titular.MaiorDeIdade())
                {
                    this.Saldo -= valor + 0.1;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        
    }
}
