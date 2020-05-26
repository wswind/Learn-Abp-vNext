using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace LearnAbp2.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class LearnAbp2MigrationsDbContextFactory : IDesignTimeDbContextFactory<LearnAbp2MigrationsDbContext>
    {
        public LearnAbp2MigrationsDbContext CreateDbContext(string[] args)
        {
            LearnAbp2EfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<LearnAbp2MigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new LearnAbp2MigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
