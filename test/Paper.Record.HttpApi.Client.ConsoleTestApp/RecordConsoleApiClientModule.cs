using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Paper.Record.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(RecordHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class RecordConsoleApiClientModule : AbpModule
    {
        
    }
}
