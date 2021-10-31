using Business.Abstractions;
using Business.Implementations;
using Business.Mappers;
using Data.EF.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Business.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        private static readonly Type[] AutoMapperProfiles =
{
            typeof(AuthorProfile)
        };

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IAsyncRepository<>), typeof(AsyncRepository<>));

            services.AddTransient<IAuthorService, AuthorService>();

            services.AddAutoMapper(AutoMapperProfiles);

            return services;
        }
    }
}
