using SocialMedia.Core.Entities;

namespace SocialMedia.Application.Models.Perfis
{
    public class PerfilViewModel
    {
        public PerfilViewModel(int id, string nomeExibicao, string localidade, string profissao)
        {
            Id = id;
            NomeExibicao = nomeExibicao;
            Localidade = localidade;
            Profissao = profissao;
        }

        public int Id { get; set; }
        public string NomeExibicao { get; set; }
        public string Localidade { get; set; }
        public string Profissao { get; set; }

        public static PerfilViewModel? FromEntity(Perfil entity)
            => new(
                entity.Id,
                entity.NomeExibicao,
                entity.Localidade,
                entity.Profissao
                );
    }
}
