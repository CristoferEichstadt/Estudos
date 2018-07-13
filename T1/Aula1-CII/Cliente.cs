using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1_CII
{
    class Cliente
    {
        public string nome, rg, endereco, cpf;
        public int idade;
        public Cliente(string nome)
        {
            this.nome = nome;
        }
        public bool MaiorDeIdade()
        {
            return this.idade >= 18;
        }
    }
}
