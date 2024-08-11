using SocialMedia.Core.Entities;

namespace SocialMedia.Application.Models.Feeds
{
    public class FeedViewModel
    {
        public FeedViewModel(int id, string nomeExibicao, DateTime dataPublicacao, string localidade, string conteudo)
        {
            Id = id;
            NomeExibicao = nomeExibicao;
            DataPublicacao = dataPublicacao;
            Localidade = localidade;
            Conteudo = conteudo;
        }

        public int Id { get; set; }
        public string NomeExibicao { get; set; }
        public DateTime DataPublicacao { get; set; }
        public string Localidade { get; set; }
        public string Conteudo { get; set; }
  
        public static FeedViewModel? FromEntitys(Perfil perfil, Publicacao publicacao)
            => new(
                publicacao.Id,
                perfil.NomeExibicao,
                publicacao.DataPublicacao,
                publicacao.Localidade,
                publicacao.Conteudo
                );
    }
}
