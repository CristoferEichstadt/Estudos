using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronicoII
{
    class Cliente
    {
        public string nome, rg, endereco, cpf;
        public int idade;
        public bool EEmancipado {get; set;}
        public Cliente(string Nome, string Rg, string Endereco, string Cpf, int Idade)
        {
            this.nome = Nome;
            this.rg = Rg;
            this.endereco = Endereco;
            this.cpf = Cpf;
            this.idade = Idade;
        }
        /*parametro de nome... vai ser opcional, pois tem um construtor de Cliente que pede o nome... e um construtor vazio, 
        sendo assim os dois válidos*/
        public Cliente() { }
        public bool MaiorDeIdade()
        {
            return this.idade >= 18;
        }
        public bool PodeAbrirConta() //método que vai verificar se o cliente pode abrir uma conta
        {
            var maiorDeIdade = (this.idade >= 18);
            var emancipado = (this.EEmancipado);
            var temCpf = !string.IsNullOrEmpty(this.cpf); //vai verificar se o atributo Cpf está preenchido

            return ((maiorDeIdade || emancipado) && temCpf); //retorna se é maior de idade ou emancipado e se tem cpf
        }
    }
}
