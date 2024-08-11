using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SocialMedia.Core.Repositories;
using SocialMedia.Infrastructure.Persistence;
using SocialMedia.Infrastructure.Persistence.Repositories;

namespace SocialMedia.Infrastructure
{
    public static class InfrastructureModule
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddData(configuration)
                .AddRepositories();

            return services;
        }

        private static IServiceCollection AddData(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("SocialMediaCs");

            services.AddDbContext<SocialMediaDbContext>(o => o.UseSqlServer(connectionString));

            return services;
        }

        private static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IContaRepository, ContaRepository>();
            services.AddScoped<IPerfilRepository, PerfilRepository>();
            services.AddScoped<IPublicacaoRepository, PublicacaoRepository>();
            services.AddScoped<IConexaoRepository, ConexaoRepository>();
            services.AddScoped<IFeedRepository, FeedRepository>();

            return services;
        }
    }
}
