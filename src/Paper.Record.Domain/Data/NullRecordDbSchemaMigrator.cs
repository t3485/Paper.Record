using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Paper.Record.Data
{
    /* This is used if database provider does't define
     * IRecordDbSchemaMigrator implementation.
     */
    public class NullRecordDbSchemaMigrator : IRecordDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}