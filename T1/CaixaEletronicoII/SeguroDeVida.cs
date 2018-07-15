using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronicoII
{
    class SeguroDeVida : ISeguroVida
    {
        public double CalculaImposto()
        {
            return 42.0;
        }
    }
}
