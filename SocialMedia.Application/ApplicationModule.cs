using Microsoft.Extensions.DependencyInjection;
using SocialMedia.Application.Services.Conexoes;
using SocialMedia.Application.Services.Contas;
using SocialMedia.Application.Services.Feeds;
using SocialMedia.Application.Services.Perfis;
using SocialMedia.Application.Services.Publicacoes;

namespace SocialMedia.Application
{
    public static class ApplicationModule
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services
                .AddServices();

            return services;
        }

        private static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IContaService, ContaService>();
            services.AddScoped<IPerfilService, PerfilService>();
            services.AddScoped<IPublicacaoService, PublicacaoService>();
            services.AddScoped<IConexaoService, ConexaoService>();
            services.AddScoped<IFeedService, FeedService>();

            return services;
        }
    }
}
