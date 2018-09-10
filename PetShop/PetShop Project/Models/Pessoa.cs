using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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

        public bool ValidaCadastroPessoa()
        {
            if (Nome.Length > 60 && string.IsNullOrWhiteSpace(Nome)
                && string.IsNullOrWhiteSpace(CpfCnpj) && CpfCnpj.Length > 14
                && RazaoSocial.Length > 80 && string.IsNullOrWhiteSpace(RazaoSocial)
                && NomeFantasia.Length > 50 && string.IsNullOrWhiteSpace(NomeFantasia)
                && InscricaoEstadual.Length > 20 && string.IsNullOrWhiteSpace(InscricaoEstadual)
                && DataNascimento.Year > 2014)
            {
                return false;
            }
            else { return true; }
        }
    }
}