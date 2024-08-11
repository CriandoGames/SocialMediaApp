using SocialMedia.Application.Models;
using SocialMedia.Application.Models.Publicacoes;
using SocialMedia.Core.Entities;
using SocialMedia.Core.Repositories;

namespace SocialMedia.Application.Services.Publicacoes
{
    public class PublicacaoService : IPublicacaoService
    {
        private readonly IPublicacaoRepository _publicacaoRepository;

        public PublicacaoService(IPublicacaoRepository publicacaoRepository)
        {
            _publicacaoRepository = publicacaoRepository;
        }

        public ResultViewModel<int> Insert(int idPerfil, CreatePublicacaoInputModel model)
        {
            var publicacao = new Publicacao(
                idPerfil,
                model.Conteudo,
                model.DataPublicacao,
                model.Localidade
                );

            _publicacaoRepository.Add(publicacao);

            return ResultViewModel<int>.Success(publicacao.Id);
        }
        public ResultViewModel Update(int id, UpdatePublicacaoInputModel model)
        {
            var publicacao = _publicacaoRepository.GetById(id);

            if (publicacao is null)
            {
                return ResultViewModel.Error("Not Found");
            }

            publicacao.Update(model.Conteudo, model.DataPublicacao, model.Localidade);

            _publicacaoRepository.Update(publicacao);

            return ResultViewModel.Success();
        }
        public ResultViewModel Delete(int id)
        {
            var publicacao = _publicacaoRepository.GetById(id);

            if (publicacao is null)
            {
                return ResultViewModel.Error("Not Found");
            }

            publicacao.SetAsDeleted();

            _publicacaoRepository.Delete(publicacao);

            return ResultViewModel.Success();
        }
        public ResultViewModel<PublicacaoViewModel?> GetById(int id)
        {
            var publicacao = _publicacaoRepository.GetById(id);

            return publicacao is null ?
                ResultViewModel<PublicacaoViewModel?>.Error("Not Found") :
                ResultViewModel<PublicacaoViewModel?>.Success(PublicacaoViewModel.FromEntity(publicacao));
        }
        public ResultViewModel<List<PublicacaoViewModel>> GetAll(int perfilId)
        {
            var listPublicacoes = _publicacaoRepository.GetAll(perfilId);

            var model = listPublicacoes.Select(
                PublicacaoViewModel.FromEntity).ToList();

            return ResultViewModel<List<PublicacaoViewModel>>.Success(model);
        }

    }
}
