using Volo.Abp.Modularity;

namespace LearnAbp2
{
    [DependsOn(
        typeof(LearnAbp2ApplicationModule),
        typeof(LearnAbp2DomainTestModule)
        )]
    public class LearnAbp2ApplicationTestModule : AbpModule
    {

    }
}