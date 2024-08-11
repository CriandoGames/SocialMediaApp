using SocialMedia.Core.Entities;

namespace SocialMedia.Core.Repositories
{
    public interface IConexaoRepository
    {
        int Add(Conexao conexao);
        void Update(Conexao conexao);
        void Delete(Conexao conexao);
        Conexao? GetById(int id);
        List<Conexao>? GetAll(int idPerfil);
    }
}
