using System.Text.RegularExpressions;

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

            return Regex.IsMatch(razaoSocial, @"^([\wáàóúéíüãõâêô]+'?\s(d[oae]\s)?)([\wáàóúéíüãõâêô]+'?\s?(d[oae]\s)?)*([\wáàóúéíüãõâêô]+'?)$");

        }
    }
}