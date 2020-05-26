using LearnAbp2.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace LearnAbp2.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(LearnAbp2EntityFrameworkCoreDbMigrationsModule),
        typeof(LearnAbp2ApplicationContractsModule)
        )]
    public class LearnAbp2DbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
