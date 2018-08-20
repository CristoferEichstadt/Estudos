using System;

namespace CursoDesignPatterns
{
    public class Conta
    {
        public String Titular { get; private set; }
        public String Numero { get; set; }
        public String Agencia { get; set; }
        public double Saldo { get; private set; }
        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }
        public Conta(String titular, double saldo, String numero, String agencia)
        {
            this.Titular = titular;
            this.Saldo = saldo;
            this.Numero = numero;
            this.Agencia = agencia;
        }
    }
}