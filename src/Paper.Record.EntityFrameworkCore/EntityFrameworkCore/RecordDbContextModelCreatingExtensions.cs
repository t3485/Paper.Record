using Microsoft.EntityFrameworkCore;
using Paper.Record.Paper;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Paper.Record.EntityFrameworkCore
{
    public static class RecordDbContextModelCreatingExtensions
    {
        public static void ConfigureRecord(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            builder.Entity<PaperRecord>(b =>
            {
                b.ToTable(RecordConsts.DbTablePrefix + "PaperRecord", RecordConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                //...
            });
        }
    }
}