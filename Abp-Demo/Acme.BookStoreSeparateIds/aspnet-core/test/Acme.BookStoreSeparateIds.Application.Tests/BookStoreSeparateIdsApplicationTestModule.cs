using Volo.Abp.Modularity;

namespace Acme.BookStoreSeparateIds
{
    [DependsOn(
        typeof(BookStoreSeparateIdsApplicationModule),
        typeof(BookStoreSeparateIdsDomainTestModule)
        )]
    public class BookStoreSeparateIdsApplicationTestModule : AbpModule
    {

    }
}