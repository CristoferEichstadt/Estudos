using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns_II.Cap7
{
    public class FinalizaPedido : IComando
    {
        private Pedido Pedido;
        public FinalizaPedido(Pedido pedido)
        {
            Pedido = pedido;
        }
        public void Executa()
        {
            Console.WriteLine("Finalizando o pedido do cliente {0}", Pedido.Cliente);

            Pedido.Finaliza();
        }
    }
}
