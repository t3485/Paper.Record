using Paper.Record.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Paper.Record.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(RecordEntityFrameworkCoreDbMigrationsModule),
        typeof(RecordApplicationContractsModule)
        )]
    public class RecordDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
