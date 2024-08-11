using SocialMedia.Core.Entities;

namespace SocialMedia.Application.Models.Perfis
{
    public class PerfilDetailsViewModel
    {
        public PerfilDetailsViewModel(int id, string nomeExibicao, string sobre, string foto, string localidade, string profissao)
        {
            Id = id;
            NomeExibicao = nomeExibicao;
            Sobre = sobre;
            Foto = foto;
            Localidade = localidade;
            Profissao = profissao;
        }

        public int Id { get; set; }
        public string NomeExibicao { get; set; }
        public string Sobre { get; set; }
        public string Foto { get; set; }
        public string Localidade { get; set; }
        public string Profissao { get; set; }

        public static PerfilDetailsViewModel? FronEntity(Perfil entity)
            => new(
                    entity.Id,
                    entity.NomeExibicao,
                    entity.Sobre,
                    entity.Foto,
                    entity.Localidade,
                    entity.Profissao
                );
    }
}
