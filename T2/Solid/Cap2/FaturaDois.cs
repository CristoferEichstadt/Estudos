namespace Solid
{
    public class FaturaDois
    {
        public double ValorMensal { get; internal set; }
        public string Nome { get; set; }
        public FaturaDois(double valor, string nome)
        {
            ValorMensal = valor;
            Nome = nome;
        }
    }
}