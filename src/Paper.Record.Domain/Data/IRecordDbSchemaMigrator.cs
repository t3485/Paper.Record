using System.Threading.Tasks;

namespace Paper.Record.Data
{
    public interface IRecordDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
