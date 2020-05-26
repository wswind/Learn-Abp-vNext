using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace LearnAbp.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class LearnAbpMigrationsDbContextFactory : IDesignTimeDbContextFactory<LearnAbpMigrationsDbContext>
    {
        public LearnAbpMigrationsDbContext CreateDbContext(string[] args)
        {
            LearnAbpEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<LearnAbpMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new LearnAbpMigrationsDbContext(builder.Options);
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
