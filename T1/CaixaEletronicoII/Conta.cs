using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronicoII
{
    class Conta
    {

        public double Saldo { get; set; }
        public int numero { get; set; }
        public Cliente Titular { get; set; }

        public Conta(double saldo, int Numero)
        {
            this.Saldo = saldo;
            this.numero = Numero;
        }

        public Conta() { }

        public bool Saca(double valor)
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

        public void Deposita(double valor)
        {
            if (valor > 0)
            {
                this.Saldo += valor;
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

    }
}

