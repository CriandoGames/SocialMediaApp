using SocialMedia.Core.Entities;

namespace SocialMedia.Core.Repositories
{
    public interface IContaRepository
    {
        int Add(Conta conta);
        void Update(Conta conta);
        Conta? GetById(int id);
        Conta? GetByEmail(string email);
        void Delete(Conta conta);
        void AddPerfil(Perfil perfil);
    }
}
