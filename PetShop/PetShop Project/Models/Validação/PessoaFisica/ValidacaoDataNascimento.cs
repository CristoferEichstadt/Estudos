using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace PetShop_Project.Models.Validação.PessoaFisica
{
    public class ValidacaoDataNascimento : IValidacao
    {
        public bool Valida(object valor)
        {
            if (valor == null)
            {
                return false;
            }

            var data = (DateTime)valor;


            if (data.Year >= 2000)
            {
                if (!Regex.IsMatch(data.ToString("dd'/'MM'/'yyyy"), @"^([0]?[1-9]|[1|2][0-9]|[3][0|1])[./-]([0]?[1-9]|[1][0-2])[./-](20[0-4]{2})$"))
                {
                    return false;
                }
            }
            else
            {
                if (!Regex.IsMatch(data.ToString("dd'/'MM'/'yyyy"), @"^([0]?[1-9]|[1|2][0-9]|[3][0|1])[./-]([0]?[1-9]|[1][0-2])[./-](19[4-9]\d)$"))
                {
                    return false;
                }

            }

            return true;
        }
    }
}