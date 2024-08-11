using SocialMedia.Application.Models;
using SocialMedia.Application.Models.Conexoes;

namespace SocialMedia.Application.Services.Conexoes
{
    public interface IConexaoService
    {
        ResultViewModel<int> Insert(CreateConexaoInputModel model);

        ResultViewModel<ConexaoViewModel?> GetById(int id);

        ResultViewModel Delete(int id);

        ResultViewModel<List<ConexaoViewModel>> GetAll(int idPerfil);
    }
}
