using System.Text.RegularExpressions;

namespace PetShop_Project.Models.Validação.Usuario
{
    public class ValidacaoSenha : IValidacao
    {
        public bool Valida(object valor)
        {
            //if (valor == null)
            //{
            //    return false;
            //}

            //var senha = (string)valor;

            //string pattern = "[A-Z][a-z]{3}[0-9]{4}";
            //Regex regex = new Regex(pattern);


            //if (!regex.IsMatch(senha, pattern))
            //{
            //    return false;
            //}

            return true;
        }
    }
}