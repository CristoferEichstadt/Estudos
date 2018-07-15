using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronicoII
{
    class TotalizadorDeContas
    {
        public double Total { get; private set; }

        public void Adiciona(Conta conta)
        {
            this.Total += conta.Saldo; //toda vez que adiciona uma conta ao relatorio, pega o saldo da conta, e adiciona ao total.
        }               
    }
}
