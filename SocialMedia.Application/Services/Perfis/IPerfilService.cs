using SocialMedia.Application.Models;
using SocialMedia.Application.Models.Perfis;

namespace SocialMedia.Application.Services.Perfis
{
    public interface IPerfilService
    {
        ResultViewModel Update(int id, UpdatePerfilInputModel model);
        ResultViewModel Delete(int id);
        ResultViewModel<PerfilViewModel?> GetById(int id);
        ResultViewModel<List<PerfilViewModel>> GetAll(int contaId);
    }
}
