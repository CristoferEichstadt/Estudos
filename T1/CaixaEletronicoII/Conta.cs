using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Benner.CaixaEletronicoII.Usuarios;

namespace Benner.CaixaEletronicoII.Contas
{
    public abstract class Conta //abstract impede que Conta seja instanciada, só as que recebem herança, conta corrente e poupança.
    {

        public double Saldo { get; protected set; } //saldo protegido para class filhas (contaPoupança).
        public int Numero { get; set; }
        public int Tipo { get; set; }
        public Cliente Titular { get; set; }

        public static int TotalDeContas { get; protected set; }

        public static int ProximaConta()
        {
            return Conta.TotalDeContas++;
        }

        //public Conta(double saldo, int numero)
        //{
        //    this.Saldo = saldo;
        //    this.Numero = numero;
        //}

        public Conta() { }

        public abstract void Saca(double valor);
        public void Deposita(double valor)
        {
            if (valor > 0)
            {
                this.Saldo += valor;
            }
            else if(valor < 0)
            {
                throw new ArgumentException();
            }
            else if(valor == 0)
            {
                throw new ValorIgualZeroException();
            }
        }
        public void Transfere(double valor, Conta destino)
        {
            if (valor > 0 && Titular.idade >= 18)
            {
                this.Saca(valor);
                destino.Deposita(valor);
            }
            else if (valor > this.Saldo)
            {
                throw new SaldoInsuficienteException();
            }
            else if(valor < 0)
            {
                throw new ArgumentException();
            }
            else if(valor == 0)
            {
                throw new ValorIgualZeroException();
            }
        }

        public override bool Equals(object obj)
        {
            Conta conta = (Conta)obj;
            return (this.Titular == conta.Titular && this.Numero == conta.Numero);
        }
    }
}

