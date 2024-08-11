using SocialMedia.Application.Models;
using SocialMedia.Application.Models.Perfis;
using SocialMedia.Core.Repositories;

namespace SocialMedia.Application.Services.Perfis
{
    internal class PerfilService : IPerfilService
    {
        private readonly IPerfilRepository _perfilRepository;
        public PerfilService(IPerfilRepository perfilRepository)
        {
            _perfilRepository = perfilRepository;
        }
        public ResultViewModel Update(int id, UpdatePerfilInputModel model)
        {
            var perfil = _perfilRepository.GetById(id);

            if(perfil is null)
            {
                return ResultViewModel.Error("Not Found");
            }

            perfil.Update(model.NomeExibicao, model.Sobre, model.Foto, model.Localidade, model.Profissao);

            _perfilRepository.Update(perfil);

            return ResultViewModel.Success();
        }
        public ResultViewModel Delete(int id)
        {
            var perfil = _perfilRepository.GetById(id);

            if (perfil is null)
            {
                return ResultViewModel.Error("Not Found");
            }

            perfil.SetAsDeleted();

            _perfilRepository.Delete(perfil);

            return ResultViewModel.Success();
        }
        public ResultViewModel<PerfilViewModel?> GetById(int id)
        {
            var perfil = _perfilRepository.GetById(id);

            return perfil is null ?
                ResultViewModel<PerfilViewModel?>.Error("Not Found") :
                ResultViewModel<PerfilViewModel?>.Success(PerfilViewModel.FromEntity(perfil));

        }

        public ResultViewModel<List<PerfilViewModel>> GetAll(int contaId)
        {
            var listaPerfis = _perfilRepository.GetAll(contaId);

            var model = listaPerfis.Select(
                PerfilViewModel.FromEntity).ToList();

            return ResultViewModel<List<PerfilViewModel>>.Success(model);

        }
    }
}
