using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Acme.BookStoreSeparateIds.EntityFrameworkCore
{
    [DependsOn(
        typeof(BookStoreSeparateIdsEntityFrameworkCoreModule)
        )]
    public class BookStoreSeparateIdsEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<BookStoreSeparateIdsMigrationsDbContext>();
        }
    }
}
