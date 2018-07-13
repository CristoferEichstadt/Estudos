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
        public Cliente(string Nome, string Rg, string Endereco, string Cpf)
        {
            this.nome = Nome;
            this.rg = Rg;
            this.endereco = Endereco;
            this.cpf = Cpf;
        }
        /*parametro de nome... vai ser opcional, pois tem um construtor de Cliente que pede o nome... e um construtor vazio, 
        sendo assim os dois válidos*/
        public Cliente() { }
        public bool MaiorDeIdade()
        {
            return this.idade >= 18;
        }
    }
}
