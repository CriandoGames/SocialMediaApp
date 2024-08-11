using SocialMedia.Application.Models;
using SocialMedia.Application.Models.Feeds;

namespace SocialMedia.Application.Services.Feeds
{
    public interface IFeedService
    {
        ResultViewModel<List<FeedViewModel>> GetAll(int idPerfil, int pagina, int tamanho);
    }
}
