using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetShop_Project.Models.Validação.PessoaJuridica
{
    public class ValidacaoNomeFantasia : IValidacao
    {
        public bool Valida(object valor)
        {
            if (valor == null)
            {
                return false;
            }

            var nomeFantasia = (string)valor;

            if (nomeFantasia.EndsWith(" ") || nomeFantasia.StartsWith(" "))
            {
                return false;
            }

            if (nomeFantasia.Length < 5 || nomeFantasia.Length > 50 || String.IsNullOrWhiteSpace(nomeFantasia) || String.IsNullOrEmpty(nomeFantasia))
            {
                return false;
            }

            return true;
        }
    }
}