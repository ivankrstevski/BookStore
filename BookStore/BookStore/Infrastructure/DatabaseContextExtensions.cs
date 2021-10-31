using Data.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BookStore.Infrastructure
{
    public static class DatabaseContextExtensions
    {
        public static void AddDatabaseContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BookStoreDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("BookStoreDbConnection"),
                    sqlOptions => sqlOptions.EnableRetryOnFailure());
            });
            services.AddScoped<DbContext>(sp => sp.GetService<BookStoreDbContext>());
        }
    }
}
