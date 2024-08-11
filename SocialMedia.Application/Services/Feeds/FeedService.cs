using SocialMedia.Application.Models;
using SocialMedia.Application.Models.Feeds;
using SocialMedia.Core.Repositories;

namespace SocialMedia.Application.Services.Feeds
{
    public class FeedService : IFeedService
    {
        private readonly IFeedRepository _feedRepository;

        public FeedService(IFeedRepository feedRepository)
        {
            _feedRepository = feedRepository;
        }


        public ResultViewModel<List<FeedViewModel>> GetAll(int idPerfil, int pagina, int tamanho)
        {
            List<FeedViewModel> listaFeedViewModel = [];
            
            var listaPublicacoes = _feedRepository.GetAll(idPerfil, pagina, tamanho);

            foreach (var publicacao in listaPublicacoes)
            {
                listaFeedViewModel.Add(FeedViewModel.FromEntitys(publicacao.Perfil, publicacao));
            }

            return ResultViewModel<List<FeedViewModel>>.Success(listaFeedViewModel.OrderByDescending(p => p.DataPublicacao).ToList());
        }

    }
}
