using Microsoft.EntityFrameworkCore;
using SocialMedia.Core.Entities;
using SocialMedia.Infrastructure.Persistence.Mappings;

namespace SocialMedia.Infrastructure.Persistence
{
    public class SocialMediaDbContext : DbContext
    {
        public SocialMediaDbContext(DbContextOptions<SocialMediaDbContext> options)
            : base(options)
        {

        }

        public DbSet<Conta> Contas { get; set; }
        public DbSet<Perfil> Perfis { get; set; }
        public DbSet<Publicacao> Publicacoes { get; set; }
        public DbSet<Conexao> Conexoes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ContaMap());
            builder.ApplyConfiguration(new PerfilMap());
            builder.ApplyConfiguration(new PublicacaoMap());
            builder.ApplyConfiguration(new ConexaoMap());

            base.OnModelCreating(builder);
        }
    }
}
