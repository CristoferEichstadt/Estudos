using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostrarNumeros
{
    class TotalizadorDeTributos
    {
        public double Total { get; private set; }

        public void Acumula(ContaPoupanca contaPoupanca)
        {
            Total += contaPoupanca.ContaPoupanca();
        }
    }
}
