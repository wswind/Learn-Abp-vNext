using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace LearnAbp2.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(LearnAbp2HttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class LearnAbp2ConsoleApiClientModule : AbpModule
    {
        
    }
}
