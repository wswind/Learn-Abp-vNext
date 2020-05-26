using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace LearnAbp2.EntityFrameworkCore
{
    public static class LearnAbp2DbContextModelCreatingExtensions
    {
        public static void ConfigureLearnAbp2(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(LearnAbp2Consts.DbTablePrefix + "YourEntities", LearnAbp2Consts.DbSchema);

            //    //...
            //});
        }
    }
}