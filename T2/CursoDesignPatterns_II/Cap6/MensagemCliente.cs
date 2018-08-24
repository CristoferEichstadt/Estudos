﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns_II.Cap6
{
    public class MensagemCliente : IMensagem
    {
        private string Nome;
        public IEnviador Enviador { get; set; }
        public MensagemCliente(string nome)
        {
            Nome = nome;
        }
        public void Envia()
        {
            Enviador.Envia(this);
        }

        public string Formata()
        {
            return string.Format("Enviando a mensagem para o cliente {0}", Nome);
        }
    }
}
