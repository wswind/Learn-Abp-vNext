using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace LearnAbp2.EntityFrameworkCore
{
    [DependsOn(
        typeof(LearnAbp2EntityFrameworkCoreModule)
        )]
    public class LearnAbp2EntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<LearnAbp2MigrationsDbContext>();
        }
    }
}
