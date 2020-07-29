using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Paper.Record.EntityFrameworkCore
{
    [DependsOn(
        typeof(RecordEntityFrameworkCoreModule)
        )]
    public class RecordEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<RecordMigrationsDbContext>();
        }
    }
}
