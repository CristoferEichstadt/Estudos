using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Cap4
{
    public class Fatura
    {

        public string Cliente { get; private set; }
        public double Valor { get; set; }
        private IList<Pagamento> pagamentos;
        public bool Pago { get; private set; }

        public Fatura(double valor, string cliente)
        {
            Cliente = cliente;
            Valor = valor;
            pagamentos = new List<Pagamento>();
            Pago = false;
        }

        public void AdicionaPagamento(Pagamento pagamento)
        {
            pagamentos.Add(pagamento);

            if (valorTotalDosPagamentos() >= Valor)
            {
                Pago = true;
            }
        }
        private double valorTotalDosPagamentos()
        {
            double total = 0;
            foreach (Pagamento pagamento in pagamentos)
            {
                total += pagamento.Valor;
            }
            return total;
        }
    }
}
