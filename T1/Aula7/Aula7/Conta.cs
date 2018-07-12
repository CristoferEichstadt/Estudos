using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula7
{
    class Conta
    {
        public double saldo;
        public int numero;
        public string titular;

        public void Saca(double valor)
        {
            if (valor >= 0 && saldo > valor)
            {
                this.saldo -= valor;
            }
        }

        public void Deposita(double valor)
        {
            if (valor > 0)
            {
                this.saldo += valor;
            }
        }

        public void Transfere(double valor, Conta destino)
        {
            /*this.saldo -= valor;
            destino.saldo += valor*/

            if (valor > 0)
            {
                this.Saca(valor);
                destino.Deposita(valor);
            }
        }
        public double CalculaRendimentoAnual()
        {
            double saldoNaqueleMes = this.saldo;

            for (int i = 0; i < 12; i++)
            {
                saldoNaqueleMes = saldoNaqueleMes * 1.007;
            }

            double rendimento = saldoNaqueleMes - this.saldo;

            return rendimento;
        }

    }
}
