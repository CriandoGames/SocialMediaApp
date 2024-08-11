using SocialMedia.Core.Entities;
namespace SocialMedia.Application.Models.Contas
{
    public partial class ContaDetailsViewModel
    {
        public ContaDetailsViewModel(int id, string nomeCompleto, string email, DateTime dataNascimento, string telefone)
        {
            Id = id;
            NomeCompleto = nomeCompleto;
            Email = email;
            DataNascimento = dataNascimento;
            Telefone = telefone;
        }

        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }

        public static ContaDetailsViewModel? FromEntity(Conta? entity)
            => entity is null ?
            null :
            new ContaDetailsViewModel(
                entity.Id,
                entity.NomeCompleto,
                entity.Email,
                entity.DataNascimento,
                entity.Telefone
                );
    }
}
