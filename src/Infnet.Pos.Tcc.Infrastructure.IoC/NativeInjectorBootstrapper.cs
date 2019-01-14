using Infnet.Pos.Tcc.Infrastructure.Data.Context;
using Microsoft.Extensions.DependencyInjection;

namespace Infnet.Pos.Tcc.Infrastructure.IoC
{
    public class NativeInjectorBootstrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Infra.Data
            services.AddDbContext<AvaliacaoContext>();
        }
    }
}