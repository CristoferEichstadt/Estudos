using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns_II.Cap6
{
    public class MensagemPorSMS : IMensagem
    {
        private string Nome;
        public MensagemPorSMS(string nome)
        {
            Nome = nome;
        }
        public void Envia()
        {
            Console.WriteLine("Enviando mensagem por SMS");
            Console.WriteLine("Mensagem enviada para o cliente {0}", Nome);
        }
    }
}
