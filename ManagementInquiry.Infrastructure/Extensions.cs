using Microsoft.Extensions.DependencyInjection;
using ManagementInquiry.Application.Contracts;
using ManagementInquiry.Domain;

namespace ManagementInquiry.Infrastructure
{
    public static class Extensions
    {
        public static IServiceCollection AddOrdersInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<ICatalogGateway, CatalogGateway>();
            services.AddTransient<ICartRepo, CartRepoInMemory>();
            return services;
        }
    }
}