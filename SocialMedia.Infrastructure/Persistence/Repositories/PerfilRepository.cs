using Microsoft.EntityFrameworkCore;
using SocialMedia.Core.Entities;
using SocialMedia.Core.Repositories;

namespace SocialMedia.Infrastructure.Persistence.Repositories
{
    public class PerfilRepository : IPerfilRepository
    {
        private readonly SocialMediaDbContext _context;

        public PerfilRepository(SocialMediaDbContext context)
        {
            _context = context;
        }

        public void Update(Perfil perfil)
        {
            _context.Perfis.Update(perfil);
            _context.SaveChanges();
        }
        public Perfil? GetById(int id)
        {
            var perfil = _context.Perfis
                .SingleOrDefault(p=> p.Id == id);

            return perfil;
        }
        public void Delete(Perfil perfil)
        {
            _context.Perfis.Update(perfil);
            _context.SaveChanges();
        }
        public List<Perfil>? GetAll(int idConta)
        {
            var listaPerfis = _context
                .Perfis
                .Where(p => p.IdConta == idConta)
                .ToList();

            return listaPerfis;
        }
    }
}
