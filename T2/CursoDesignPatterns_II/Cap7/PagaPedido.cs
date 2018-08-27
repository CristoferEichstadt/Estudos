using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns_II.Cap7
{
    public class PagaPedido : IComando
    {
        private Pedido pedido;
        public PagaPedido(Pedido Pedido)
        {   
            pedido = Pedido;
        }
        public void Executa()
        {
            Console.WriteLine("Pagando o pedido do cliente {0}", pedido.Cliente);
            pedido.Paga();
        }
    }
}
