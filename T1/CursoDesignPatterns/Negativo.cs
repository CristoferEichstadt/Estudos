using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class Negativo : IEstadoDaConta
    {
        public void Saca(Conta conta, double valor)
        {
            throw new Exception("Sua conta está no vermelho. Não é possível sacar!");
        }

        public void Deposita(Conta conta, double valor)
        {
            conta.Saldo += valor * 0.95;
            if (conta.Saldo > 0) conta.Estado = new Positivo();
        }
    }
}
