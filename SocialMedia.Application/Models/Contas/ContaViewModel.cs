using SocialMedia.Core.Entities;
namespace SocialMedia.Application.Models.Contas
{
    public partial class ContaDetailsViewModel
    {
        public class ContaViewModel
        {
            public ContaViewModel(int id, string nomeCompleto, string email, string telefone)
            {
                Id = id;
                NomeCompleto = nomeCompleto;
                Email = email;
                Telefone = telefone;
            }

            public int Id { get; set; }
            public string NomeCompleto { get; set; }
            public string Email { get; set; }
            public string Telefone { get; set; }

            public static ContaViewModel? FromEntity(Conta entity)
                => new(
                    entity.Id, 
                    entity.NomeCompleto, 
                    entity.Email, 
                    entity.Telefone
                    );
        }
    }
}
