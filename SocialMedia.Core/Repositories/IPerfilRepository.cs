using SocialMedia.Core.Entities;

namespace SocialMedia.Core.Repositories
{
    public interface IPerfilRepository
    {
        void Update(Perfil perfil);
        Perfil? GetById(int id);
        void Delete(Perfil perfil);
        List<Perfil>? GetAll(int idConta);
    }
}
