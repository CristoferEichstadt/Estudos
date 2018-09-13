using System.Text.RegularExpressions;

namespace PetShop_Project.Models.Validação.PessoaFisica
{
    public class ValidacaoNome : IValidacao
    {
        public bool Valida(object valor)
        {
            if (valor == null)
            {
                return false;
            }

            var nome = (string)valor;

            return Regex.IsMatch(nome, @"^([A-Z]'?[a-záüóúéíãõàâêô]{2,}\s(d[oae]\s)?)([A-Z]'?[a-záàóúéíüãõâêô]{2,}\s?(d[oae]\s)?)*([A-Z]'?[a-záüàóúéíãõâêô]{2,})$");
        }
    }
}