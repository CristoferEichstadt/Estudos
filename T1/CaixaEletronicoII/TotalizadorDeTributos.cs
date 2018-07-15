using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronicoII
{
    class TotalizadorDeTributos
    {
        public double Total { get; private set; }

        public void Acumula(Tributavel contaPoupanca)
        {
            Total += contaPoupanca.CalculaTributo();
        }
    }
}
