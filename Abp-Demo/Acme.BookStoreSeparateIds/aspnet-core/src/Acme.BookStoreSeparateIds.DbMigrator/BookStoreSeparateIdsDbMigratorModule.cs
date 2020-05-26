using Acme.BookStoreSeparateIds.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Acme.BookStoreSeparateIds.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(BookStoreSeparateIdsEntityFrameworkCoreDbMigrationsModule),
        typeof(BookStoreSeparateIdsApplicationContractsModule)
        )]
    public class BookStoreSeparateIdsDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
