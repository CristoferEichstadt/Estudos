namespace Solid
{
    public class Fatura
    {
        public double ValorMensal { get; internal set; }
        public string Nome { get; set; }

        public Fatura(double valor, string nome)
        {
            ValorMensal = valor;
            Nome = nome;
        }
    }
}