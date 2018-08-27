using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Cap5
{
    public class ContaEstudante : ContaComum
    {
        public int Milhas { get; protected set; }
        private GerenciarSaldo Gerenciador;
        public ContaEstudante()
        {
            Gerenciador = new GerenciarSaldo();
        }
        public void Deposita(double valor)
        {
            Gerenciador.Deposita(valor);
            this.Milhas += (int)valor;
        }
    }
}
