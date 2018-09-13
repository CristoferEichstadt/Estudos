using System.Text.RegularExpressions;

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

            return Regex.IsMatch(nomeFantasia, @"^([\wáàóúéíüãõâêô]+'?\s(d[oae]\s)?)([\wáàóúéíüãõâêô]+'?\s?(d[oae]\s)?)*([\wáàóúéíüãõâêô]+'?)$");
        }
    }
}