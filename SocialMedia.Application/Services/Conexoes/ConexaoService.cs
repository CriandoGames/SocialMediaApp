using SocialMedia.Application.Models;
using SocialMedia.Application.Models.Conexoes;
using SocialMedia.Core.Entities;
using SocialMedia.Core.Repositories;

namespace SocialMedia.Application.Services.Conexoes
{
    internal class ConexaoService : IConexaoService
    {
        private readonly IConexaoRepository _conexaoRepository;

        public ConexaoService(IConexaoRepository conexaoRepository)
        {
            _conexaoRepository = conexaoRepository;
        }

        public ResultViewModel<int> Insert(CreateConexaoInputModel model)
        {
            var conexao = new Conexao(
                model.IdPerfil,
                model.IdPerfilSeguido
                );

            _conexaoRepository.Add(conexao);

            return ResultViewModel<int>.Success(conexao.Id);
        }
        public ResultViewModel<ConexaoViewModel?> GetById(int id)
        {
            var conexao = _conexaoRepository.GetById(id);

            return conexao is null ?
                ResultViewModel<ConexaoViewModel?>.Error("Not found") :
                ResultViewModel<ConexaoViewModel?>.Success(ConexaoViewModel.FromEntity(conexao));
        }

        public ResultViewModel Delete(int id)
        {
            var conexao = _conexaoRepository.GetById(id);

            if (conexao is null)
            {
                return ResultViewModel.Error("Not found");
            }

            conexao.SetAsDeleted();

            _conexaoRepository.Delete(conexao);

            return ResultViewModel.Success();
        }

        public ResultViewModel<List<ConexaoViewModel>> GetAll(int idPerfil)
        {
            var listaConexoes = _conexaoRepository.GetAll(idPerfil);

            var model = listaConexoes.Select(
                ConexaoViewModel.FromEntity).ToList();

            return ResultViewModel<List<ConexaoViewModel>>.Success(model);
        }
    }
}
