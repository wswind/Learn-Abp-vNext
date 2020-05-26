using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace LearnAbp.EntityFrameworkCore
{
    [DependsOn(
        typeof(LearnAbpEntityFrameworkCoreModule)
        )]
    public class LearnAbpEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<LearnAbpMigrationsDbContext>();
        }
    }
}
