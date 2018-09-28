using PetShop_Project.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace PetShop_Project.Models.Validação.Subcategoria
{
    public class ValidacaoNomeSubcategoria : IValidacao
    {
        public bool Valida(object valor)
        {
            if (valor == null)
            {
                return false;
            }

            var nome = (string)valor;

            if (nome.Length < 2 || nome.Length > 25)
            {
                return false;
            }

            if (Regex.IsMatch(nome, @"[!""#$%&'()*+,-./:;?@[\\\]_`{|}~]") || Regex.IsMatch(nome, @"[\\d]"))
            {
                return false;
            }

            SubcategoriaDAO dao = new SubcategoriaDAO();
            if (dao.BuscaPorNome(nome))
            {
                return false;
            }

            return true;
        }
    }
}