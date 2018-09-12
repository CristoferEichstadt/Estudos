﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace PetShop_Project.Models.Validação.PessoaJuridica
{
    public class ValidacaoEmail : IValidacao
    {
        public bool Valida(object valor)
        {
            if (valor == null)
            {
                return false;
            }

            var email = (string)valor;
            
            if (email.EndsWith(" ") || email.StartsWith(" "))
            {
                return false;
            }

            if (email.Length < 5 || email.Length > 50)
            {
                return false;
            }

            string emailModelo = @"^(([A-Za-z0-9]+_+)|([A-Za-z0-9]+\-+)|([A-Za-z0-9]+\.+)|([A-Za-z0-9]+\++))*[A-Za-z0-9]+@((\w+\-+)|(\w+\.))*\w{1,63}\.[a-zA-Z]{2,6}$";

            if (!Regex.IsMatch(email, emailModelo))
            {
                return false;
            }

            return true;
        }
    }
}