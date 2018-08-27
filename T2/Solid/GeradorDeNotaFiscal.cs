using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    public class GeradorDeNotaFiscal
    {
        private IList<IAcaoAposGerarNota> Acoes;

        public GeradorDeNotaFiscal(IList<IAcaoAposGerarNota> acoes)
        {
            Acoes = acoes;
        }

        public NotaFiscal Gera(Fatura fatura)
        {
            double valor = fatura.ValorMensal;
            NotaFiscal nf = new NotaFiscal(valor, ImpostoSimplesSobre0(valor));

            foreach (var acao in Acoes)
            {
                acao.Executa(nf);
            }

            return nf;
        }

        private object ImpostoSimplesSobre0(double valor)
        {
            return valor * 0.06
        }
    }
}
