using SocialMedia.Core.Entities;

namespace SocialMedia.Application.Models.Publicacoes
{
    public class PublicacaoViewModel
    {
        public PublicacaoViewModel(int id, string conteudo, DateTime dataPublicacao, string localidade)
        {
            Id = id;
            Conteudo = conteudo;
            DataPublicacao = dataPublicacao;
            Localidade = localidade;
        }

        public int Id { get; set; }
        public string Conteudo { get;  set; }
        public DateTime DataPublicacao { get;  set; }
        public string Localidade { get;  set; }

        public static PublicacaoViewModel? FromEntity(Publicacao entity)
            => new(
                entity.Id,
                entity.Conteudo,
                entity.DataPublicacao,
                entity.Localidade
                );
    }
}
