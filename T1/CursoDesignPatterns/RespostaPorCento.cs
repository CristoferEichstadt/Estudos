using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class RespostaPorCento : IResposta
    {
        public IResposta OutraResposta { get; set; }

        public RespostaPorCento(IResposta outraResposta)
        {
            this.OutraResposta = outraResposta;
        }

        public RespostaPorCento()
        {
            this.OutraResposta = null;
        }

        public void Responde(Requisicao requisicao, Conta conta)
        {
            if (requisicao.Formato == Formato.PORCENTO)
            {
                Console.WriteLine(conta.Titular + '%' + conta.Saldo);
            }
            else if (OutraResposta != null)
            {
                OutraResposta.Responde(requisicao, conta);
            }
            else
            {
                throw new Exception("Formato de resposta não encontrado");
            }
        }
    }
}
