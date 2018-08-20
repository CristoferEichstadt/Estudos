using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class RespostaCsv : IResposta
    {
        public IResposta OutraResposta { get; set; }
        public void Responde(Requisicao requisicao, Conta conta)
        {
            if (requisicao.Formato == Formato.CSV)
            {
                Console.WriteLine(conta.Titular + ";" + conta.Saldo);
            }
            else
            {
                OutraResposta.Responde(requisicao, conta);
            }
        }
    }
}
