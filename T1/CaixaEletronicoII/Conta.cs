using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benner.CaixaEletronicoII.Contas
{
    abstract class Conta //abstract impede que Conta seja instanciada, só as que recebem herança, conta corrente e poupança.
    {

        public double Saldo { get; protected set; } //saldo protegido para class filhas (contaPoupança).
        public int numero { get; set; }
        public int Tipo { get; set; }
        public Cliente Titular { get; set; }

        public Conta(double saldo, int Numero)
        {
            this.Saldo = saldo;
            this.numero = Numero;
        }

        public Conta() { }

        public abstract void Saca(double valor);
        public void Deposita(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException();
            }
            if (valor == 0)
            {
                throw new ValorIgualZeroException();
            }
            if (valor > 0)
            {
                this.Saldo += valor;
            }
        }
        public void Transfere(double valor, Conta destino)
        {
            if (valor > 0)
            {
                this.Saca(valor);
                destino.Deposita(valor);
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
    }
}

