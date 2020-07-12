using Business.Service.Interfaces;
using Business.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Angular_ServerSidePagination_BackEnd.Core.Configurations
{
    public static class BusinessServiceConfigurations
    {
        public static IServiceCollection ConfigureBusinessServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IUserService), typeof(UserService));

            return services;
        }
    }
}
