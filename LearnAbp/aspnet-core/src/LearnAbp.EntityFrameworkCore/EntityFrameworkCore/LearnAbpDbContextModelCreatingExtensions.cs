using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace LearnAbp.EntityFrameworkCore
{
    public static class LearnAbpDbContextModelCreatingExtensions
    {
        public static void ConfigureLearnAbp(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(LearnAbpConsts.DbTablePrefix + "YourEntities", LearnAbpConsts.DbSchema);

            //    //...
            //});
        }
    }
}