using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Paper.Record.Data;
using Volo.Abp.DependencyInjection;

namespace Paper.Record.EntityFrameworkCore
{
    public class EntityFrameworkCoreRecordDbSchemaMigrator
        : IRecordDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreRecordDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the RecordMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<RecordMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}