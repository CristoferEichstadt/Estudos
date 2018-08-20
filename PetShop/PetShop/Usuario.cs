namespace PetShop
{
    public class Usuario
    {
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }
        public char Perfil { get; set; }
        public Pessoa Pessoa { get; set; }
        public Pedido Pedido { get; set; }
    }
}