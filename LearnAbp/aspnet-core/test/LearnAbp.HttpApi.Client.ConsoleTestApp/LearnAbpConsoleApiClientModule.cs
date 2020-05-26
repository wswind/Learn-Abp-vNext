using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace LearnAbp.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(LearnAbpHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class LearnAbpConsoleApiClientModule : AbpModule
    {
        
    }
}
