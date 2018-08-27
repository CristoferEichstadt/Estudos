using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Cap5
{
    public class ContaComum
    {

        private GerenciarSaldo Gerenciador { get; }
        public ContaComum()
        {
            Gerenciador = new GerenciarSaldo();
        }
        public double Saldo { get; protected set; }
        public void Deposita(double valor)
        {
            Gerenciador.Deposita(valor);
        }
        public void Saca(double valor)
        {
            Gerenciador.Saca(valor - 100);
        }
        public virtual void somaInvestimento()
        {
            Gerenciador.SomaInvestimento(1.1);
        }
    }
}
