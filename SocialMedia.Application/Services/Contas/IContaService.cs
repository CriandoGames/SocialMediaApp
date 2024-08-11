using SocialMedia.Application.Models;
using SocialMedia.Application.Models.Contas;
using SocialMedia.Application.Models.Perfis;
using static SocialMedia.Application.Models.Contas.ContaDetailsViewModel;

namespace SocialMedia.Application.Services.Contas
{
    public interface IContaService
    {
        ResultViewModel<int> Insert(CreateContaInputModel model);
        ResultViewModel Update(int id, UpdateContaInputModel model);
        ResultViewModel Delete(int id);
        ResultViewModel<ContaViewModel?> GetById(int id);
        ResultViewModel<ContaViewModel?> GetByEmail(string email);
        ResultViewModel MudarSenha(string email, UpdateSenhaContaInputModel model);
        ResultViewModel Login(string email, string senha);
        ResultViewModel Perfil(int id, CreatePerfilInputModel model);
    }
}
