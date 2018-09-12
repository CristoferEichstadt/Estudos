using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetShop_Project.Models.Validação.PessoaJuridica
{
    public class ValidacaoRazaoSocial : IValidacao
    {
        public bool Valida(object valor)
        {
            if (valor == null)
            {
                return false;
            }

            var razaoSocial = (string)valor;

            if (razaoSocial.EndsWith(" ") || razaoSocial.StartsWith(" "))
            {
                return false;
            }

            if (razaoSocial.Length < 5 || razaoSocial.Length > 70 || String.IsNullOrWhiteSpace(razaoSocial) || String.IsNullOrEmpty(razaoSocial))
            {
                return false;
            }

            return true;
        }
    }
}