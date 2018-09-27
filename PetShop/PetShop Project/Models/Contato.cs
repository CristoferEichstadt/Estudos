namespace PetShop_Project.Models
{
    public class Contato
    {
        public string Email { get; set; }
        public string Celular { get; set; }
        public string Telefone { get; set; }
        public Pessoa Pessoa { get; set; }
        public int PessoaId { get; set; }
    }
}