using SocialMedia.Core.Entities;

namespace SocialMedia.Core.Repositories
{
    public interface IPublicacaoRepository
    {
        int Add(Publicacao publicacao);
        void Delete(Publicacao publicacao);
        void Update(Publicacao publicacao);
        Publicacao? GetById(int id);
        List<Publicacao>? GetAll(int idPerfil);
    }
}
