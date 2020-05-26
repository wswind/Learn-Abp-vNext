using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Acme.BookStoreSeparateIds.EntityFrameworkCore
{
    public static class BookStoreSeparateIdsDbContextModelCreatingExtensions
    {
        public static void ConfigureBookStoreSeparateIds(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(BookStoreSeparateIdsConsts.DbTablePrefix + "YourEntities", BookStoreSeparateIdsConsts.DbSchema);

            //    //...
            //});
        }
    }
}