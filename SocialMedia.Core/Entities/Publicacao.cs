namespace SocialMedia.Core.Entities
{
    public class Publicacao : BaseEntity
    {
        public Publicacao(int idPerfil, string conteudo, DateTime dataPublicacao, string localidade)
            : base()
        {
            IdPerfil = idPerfil;
            Conteudo = conteudo;
            DataPublicacao = dataPublicacao;
            Localidade = localidade;
        }

        public int IdPerfil { get; private set; }
        public Perfil Perfil { get; private set; }
        public string Conteudo { get; private set; }
        public DateTime DataPublicacao { get; private set; }
        public string Localidade { get; private set; }

        public void Update(string conteudo, DateTime dataPublicacao, string localidade)
        {
            Conteudo = conteudo;
            DataPublicacao = dataPublicacao;
            Localidade = localidade;
        }

    }

}
