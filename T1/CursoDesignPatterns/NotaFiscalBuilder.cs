using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class NotaFiscalBuilder
    {
        private String RazaoSocial { get; set; }
        private String Cnpj { get; set; }
        private List<ItemDaNota> todosItens = new ArrayList<ItemDaNota>();
        private double ValorBruto { get; set; }
        private double Impostos { get; set; }
        private String Observacoes { get; set; }
        private DateTime Data { get; set; }

        public NotaFiscalBuilder Com(ItemDaNota item)
        {
            this.todosItens.Add(item);
            this.ValorBruto += item.Valor;
            this.Impostos += item.Valor * 0.05;
            return this;
        }
        public NotaFiscalBuilder ParaEmpresa(String razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder ComCnpj(String cnpj)
        {
            this.Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder ComObservacoes(String observacoes)
        {
            this.Observacoes = observacoes;

            return this;
        }

        public NotaFiscalBuilder NaData(DateTime novaData)
        {
            this.Data = novaData;

            return this;
        }

        public NotaFiscal Constroi()
        {
            return new NotaFiscal(RazaoSocial, Cnpj, Data, ValorBruto,
                                Impostos, todosItens, Observacoes);
        }
    }
}
