using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using LearnAbp2.Data;
using Volo.Abp.DependencyInjection;

namespace LearnAbp2.EntityFrameworkCore
{
    public class EntityFrameworkCoreLearnAbp2DbSchemaMigrator
        : ILearnAbp2DbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreLearnAbp2DbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the LearnAbp2MigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<LearnAbp2MigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}