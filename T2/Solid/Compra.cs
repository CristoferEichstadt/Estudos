namespace Solid
{
    public class Compra
    {
        public double Valor { get; internal set; }
        public string Cidade { get; internal set; }
        public Compra(string cidade, double valor)
        {
            Valor = valor;
            Cidade = cidade;
        }
    }
}