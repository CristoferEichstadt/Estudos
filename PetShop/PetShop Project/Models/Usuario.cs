using PetShop_Project.Models.Validação.PessoaJuridica;
using PetShop_Project.Models.Validação.Usuario;

namespace PetShop_Project.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }
        public char Perfil { get; set; }
        public Pessoa Pessoa { get; set; }
        public bool Valida()
        {
            return new ValidacaoEmail().Valida(Email)
                && new ValidacaoSenha().Valida(Senha);
        }
    }
}