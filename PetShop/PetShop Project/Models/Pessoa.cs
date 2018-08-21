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
        public string TipoPessoa { get; set; }
        public DateTime DataNascimento { get; set; }
        public Endereco Endereco { get; set; }
        public Contato Contato { get; set; }
    }
}