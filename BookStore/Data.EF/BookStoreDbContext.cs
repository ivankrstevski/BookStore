using Data.EF.DataSeed;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using System.Reflection;

namespace Data.EF
{
    public class BookStoreDbContext : DbContext
    {
        public const string SystemUser = "System User";
        private readonly IConfiguration _configuration;

        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options,
            IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            DataSeed(modelBuilder);
        }

        private static void DataSeed(ModelBuilder modelBuilder)
        {
            var seedTypes = typeof(IDataSeed).Assembly.GetTypes()
                .Where(type => typeof(IDataSeed).IsAssignableFrom(type) && type.IsClass).ToList();

            foreach (var seedType in seedTypes)
            {
                var seedService = (IDataSeed)Activator.CreateInstance(seedType);
                seedService.Seed(modelBuilder, SystemUser);
            }
        }
    }
}
