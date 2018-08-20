using System;

namespace CursoDesignPatterns
{
    public class Conta
    {
        public String Titular { get; set; }
        public String Numero { get; set; }
        public String Agencia { get; set; }
        public double Saldo { get; set; }
        public DateTime DataAbertura { get; set; }

        public IEstadoDaConta Estado;

        public void Saca(double valor)
        {
            Estado.Saca(this, valor);
        }

        public void Deposita(double valor)
        {
            Estado.Deposita(this, valor);
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