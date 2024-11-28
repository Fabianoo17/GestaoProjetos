using GestaoProjetos.Domain.Interfaces.Repositories;
using GestaoProjetos.Infra.Data.Contexts;
using GestaoProjetos.Infra.Data.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GestaoProjetos.Infra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IProjetoRepository, ProjetoRepository>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddDbContext<GestaoContratosContext>();

            return services;
        }
    }
}
