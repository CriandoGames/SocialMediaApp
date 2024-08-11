namespace SocialMedia.Application.Models.Contas
{
    public class CreateContaInputModel
    {
        public string NomeCompleto { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
    }
}
