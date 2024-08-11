using Microsoft.EntityFrameworkCore;
using SocialMedia.Core.Entities;
using SocialMedia.Core.Repositories;

namespace SocialMedia.Infrastructure.Persistence.Repositories
{
    public class FeedRepository : IFeedRepository
    {

        private readonly SocialMediaDbContext _context;

        public FeedRepository(SocialMediaDbContext context)
        {
            _context = context;
        }

        public List<Publicacao>? GetAll(int idPerfil, int pagina, int tamanho)
        {
            var perfil = _context.Perfis
                .Include(p => p.ConexoesPerfil)
                .ThenInclude(p => p.PerfilSeguido)
                .ThenInclude(p => p.Publicacoes)
                .SingleOrDefault(p => p.Id == idPerfil);

            if (perfil != null)
            {
                var publicacoes = perfil.ConexoesPerfil
                    .SelectMany(cs => cs.PerfilSeguido.Publicacoes)
                    .OrderBy(p => p.DataPublicacao)
                    .Skip(pagina)
                    .Take(tamanho)
                    .ToList();
                
                return publicacoes;
            }

            return [];
        }




    }
}
