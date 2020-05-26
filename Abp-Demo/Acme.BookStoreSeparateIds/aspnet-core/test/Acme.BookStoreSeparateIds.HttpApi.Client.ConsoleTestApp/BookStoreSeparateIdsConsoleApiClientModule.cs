using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Acme.BookStoreSeparateIds.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(BookStoreSeparateIdsHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class BookStoreSeparateIdsConsoleApiClientModule : AbpModule
    {
        
    }
}
