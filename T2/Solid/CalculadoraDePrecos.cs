using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    public class CalculadoraDePrecos
    {
        private ITabelaDePreco Tabela;
        private IServicoDeEntrega Entrega;
        public CalculadoraDePrecos(ITabelaDePreco tabela, IServicoDeEntrega entrega)
        {
            Tabela = tabela;
            Entrega = entrega;
        }

        public double Calcula(Compra produto)
        {
            double desconto = this.Tabela.DescontoPara(produto.Valor);
            double frete = this.Entrega.Para(produto.Cidade);

            return produto.Valor * (1 - desconto) + frete;
        }
    }
}
