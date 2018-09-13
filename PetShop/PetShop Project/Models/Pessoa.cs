using PetShop_Project.Models.Validação.PessoaFisica;
using PetShop_Project.Models.Validação.PessoaJuridica;
using System;

namespace PetShop_Project.Models
{
    public class Pessoa
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public string CpfCnpj { get; set; }
        public char TipoPessoa { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string InscricaoEstadual { get; set; }
        public DateTime DataNascimento { get; set; }
        public Endereco Endereco { get; set; }
        public Contato Contato { get; set; }
        public bool ValidaCadastroPessoaFisica()
        {
            return new ValidacaoCPF().Valida(CpfCnpj)
                && new ValidacaoNome().Valida(Nome)
                && new ValidacaoDataNascimento().Valida(DataNascimento);
        }
        public bool ValidaCadastroPessoaJuridica()
        {
            return new ValidacaoRazaoSocial().Valida(RazaoSocial)
                && new ValidacaoCNPJ().Valida(CpfCnpj)
                && new ValidacaoNomeFantasia().Valida(NomeFantasia);
        }
    }
}
