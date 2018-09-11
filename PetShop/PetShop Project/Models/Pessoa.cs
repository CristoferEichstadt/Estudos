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
            if (Nome == null)
            {
                return false;
            }

            if (CpfCnpj == "00000000000" || CpfCnpj == "11111111111" || CpfCnpj == "22222222222" || CpfCnpj == "33333333333" || CpfCnpj == "44444444444" ||
                CpfCnpj == "55555555555" || CpfCnpj == "66666666666" || CpfCnpj == "77777777777" || CpfCnpj == "88888888888" || CpfCnpj == "99999999999")
            {
                return false;
            }

            var r = 0;
            var s = 0;
            for (int i = 1; i <= 9; i++)
            {
                s = s + Convert.ToInt32(CpfCnpj[i - 1]) * (11 - i);
                r = (s * 10) % 11;
            }

            if ((r == 10) || (r == 11))
            {
                r = 0;
            }

            if (r != Convert.ToInt32(CpfCnpj[9]))
            {
                return false;
            }


            s = 0;
            for (int i = 1; i <= 10; i++)
            {
                s = s + Convert.ToInt32(CpfCnpj[i - 1]) * (12 - i);
            }


            r = (s * 10) % 11;
            if ((r == 10) || (r == 11))
            {
                r = 0;
            }

            if (r != Convert.ToInt32(CpfCnpj[10]))
            {
                return false;
            }

            return true;
        }
        public bool ValidaCadastroPessoaJuridica()
        {
            return new ValidacaoRazaoSocial().Valida(RazaoSocial)
                && new ValidacaoCNPJ().Valida(CpfCnpj)
                && new ValidacaoNomeFantasia().Valida(NomeFantasia);
        }
    }
}
