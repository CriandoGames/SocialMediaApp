using SocialMedia.Application.Models;
using SocialMedia.Application.Models.Publicacoes;

namespace SocialMedia.Application.Services.Publicacoes
{
    public interface IPublicacaoService
    {
        ResultViewModel<int> Insert(int id, CreatePublicacaoInputModel model);
        ResultViewModel Update(int id, UpdatePublicacaoInputModel model);
        ResultViewModel Delete(int id);
        ResultViewModel<PublicacaoViewModel?> GetById(int id);
        ResultViewModel<List<PublicacaoViewModel>> GetAll(int perfilId);
    }
}
