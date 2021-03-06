﻿using System;

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
        public Endereco Endereco { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}