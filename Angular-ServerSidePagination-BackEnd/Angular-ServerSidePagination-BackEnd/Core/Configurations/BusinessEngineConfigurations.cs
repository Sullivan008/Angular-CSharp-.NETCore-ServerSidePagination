using Business.Engine.Engines;
using Business.Engine.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Angular_ServerSidePagination_BackEnd.Core.Configurations
{
    public static class BusinessEngineConfiguration
    {
        public static IServiceCollection ConfigureBusinessEngines(this IServiceCollection services)
        {
            services.AddScoped<IUserEngine, UserEngine>();

            return services;
        }
    }
}
