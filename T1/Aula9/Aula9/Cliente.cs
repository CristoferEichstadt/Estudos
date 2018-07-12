using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula9
{
    class Cliente
    {
        public string nome, rg, endereco, cpf;
        public int idade;

        public bool MaiorDeIdade()
        {
            return this.idade >= 18;
        }

        
    }
}

