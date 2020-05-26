using Acme.BookStoreSeparateIds.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Acme.BookStoreSeparateIds
{
    [DependsOn(
        typeof(BookStoreSeparateIdsEntityFrameworkCoreTestModule)
        )]
    public class BookStoreSeparateIdsDomainTestModule : AbpModule
    {

    }
}