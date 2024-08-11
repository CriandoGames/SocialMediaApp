namespace SocialMedia.Application.Models.Publicacoes
{
    public class CreatePublicacaoInputModel
    {
        public string Conteudo { get; set; }
        public DateTime DataPublicacao { get; set; }
        public string Localidade { get; set; }
    }
}
