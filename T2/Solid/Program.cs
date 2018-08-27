using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            Compra compra = new Compra("Sao paulo", 500);
            CalculadoraDePrecos calc = new CalculadoraDePrecos(new TabelaDePrecoPadrao(), new Frete());

            double resultado = calc.Calcula(compra);

            Console.WriteLine("O preço da compra é: " + resultado);
            Console.ReadKey();
        }
    }
}
