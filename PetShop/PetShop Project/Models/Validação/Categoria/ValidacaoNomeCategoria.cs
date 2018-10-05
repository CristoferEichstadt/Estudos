using PetShop_Project.DAO;
using System.Text.RegularExpressions;

namespace PetShop_Project.Models.Validação.Categoria
{
    public class ValidacaoNomeCategoria : IValidacao
    {
        public bool Valida(object valor)
        {
            if (valor == null)
            {
                return false;
            }

            var nome = (string)valor;

            if (nome.Length < 2 || nome.Length > 20)
            {
                return false;
            }

            if (Regex.IsMatch(nome, @"[[!""#$%&'()*+,-.¨<>\/:;?@[\\\]_`°^₢{|}~¹ºª§¬¢£³²']"))
            {
                return false;
            }

            if (Regex.IsMatch(nome, @"[0-9]"))
            {
                return false;
            }

            CategoriaDAO dao = new CategoriaDAO();
            if (dao.BuscaPorNome(nome))
            {
                return false;
            }

            return true;
        }
    }
}