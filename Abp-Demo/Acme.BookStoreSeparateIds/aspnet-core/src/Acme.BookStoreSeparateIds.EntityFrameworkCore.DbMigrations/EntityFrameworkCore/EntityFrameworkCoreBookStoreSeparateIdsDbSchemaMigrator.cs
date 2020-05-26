using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Acme.BookStoreSeparateIds.Data;
using Volo.Abp.DependencyInjection;

namespace Acme.BookStoreSeparateIds.EntityFrameworkCore
{
    public class EntityFrameworkCoreBookStoreSeparateIdsDbSchemaMigrator
        : IBookStoreSeparateIdsDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreBookStoreSeparateIdsDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the BookStoreSeparateIdsMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<BookStoreSeparateIdsMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}