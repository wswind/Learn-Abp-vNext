using LearnAbp2.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace LearnAbp2
{
    [DependsOn(
        typeof(LearnAbp2EntityFrameworkCoreTestModule)
        )]
    public class LearnAbp2DomainTestModule : AbpModule
    {

    }
}