using System;

namespace PetShop
{
    public class Pessoa
    {
        public int Id { get; private set; }
        public Usuario Usuario { get; set; }
        public string Nome { get; set; }
        public string CpfCnpj { get; set; }
        public string TipoPessoa { get; set; }
        public string Celular { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string Cep { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}