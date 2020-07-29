using Paper.Record.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Paper.Record
{
    [DependsOn(
        typeof(RecordEntityFrameworkCoreTestModule)
        )]
    public class RecordDomainTestModule : AbpModule
    {

    }
}