using Volo.Abp.Modularity;

namespace Paper.Record
{
    [DependsOn(
        typeof(RecordApplicationModule),
        typeof(RecordDomainTestModule)
        )]
    public class RecordApplicationTestModule : AbpModule
    {

    }
}