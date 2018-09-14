using System.Text.RegularExpressions;

namespace PetShop_Project.Models.Validação.PessoaJuridica
{
    public class ValidacaoIE : IValidacao
    {
        public bool Valida(object valor)
        {
            if (valor == null)
            {
                return false;
            }

            var ie = (string)valor;

            return Regex.IsMatch(ie, @"^\d{4,11}");
        }
    }
}