﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronicoII
{
    class ContaCorrente : Conta
    {
        public override void Saca(double valor)
        {
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
            if (valor < this.Saldo && this.Titular.MaiorDeIdade())
            {
                this.Saldo -= valor + 0.1;
            }
            if (Convert.ToDouble(valor) == 0)
            {
                throw new ValorDigitadoLetrasExeption();
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
