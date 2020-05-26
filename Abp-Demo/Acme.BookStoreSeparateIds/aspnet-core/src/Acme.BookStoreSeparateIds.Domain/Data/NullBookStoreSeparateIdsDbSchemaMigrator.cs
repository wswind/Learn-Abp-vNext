using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.BookStoreSeparateIds.Data
{
    /* This is used if database provider does't define
     * IBookStoreSeparateIdsDbSchemaMigrator implementation.
     */
    public class NullBookStoreSeparateIdsDbSchemaMigrator : IBookStoreSeparateIdsDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}