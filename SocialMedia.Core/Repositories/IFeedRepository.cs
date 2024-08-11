using SocialMedia.Core.Entities;

namespace SocialMedia.Core.Repositories
{
    public interface IFeedRepository
    {
        List<Publicacao>? GetAll(int idPerfil, int pagina, int tamanho);
    }
}
