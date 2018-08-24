using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns_II.Cap6
{
    public class MensagemPorEmail : IMensagem
    {
        private string Nome;
        public MensagemPorEmail(string nome)
        {
            Nome = nome;
        }
        public void Envia()
        {
            Console.WriteLine("Enviando mensagem por e-mail");
            Console.WriteLine("Mensagem enviada para o cliente {0}", Nome);
        }
    }
}
