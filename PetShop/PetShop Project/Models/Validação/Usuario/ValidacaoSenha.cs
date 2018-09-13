using System.Text.RegularExpressions;

namespace PetShop_Project.Models.Validação.Usuario
{
    public class ValidacaoSenha : IValidacao
    {
        public bool Valida(object valor)
        {
            if (valor == null)
            {
                return false;
            }

            var senha = (string)valor;

            return Regex.IsMatch(senha, @"^[A-Z][a-z]{3}\d{4}$");
        }
    }
}