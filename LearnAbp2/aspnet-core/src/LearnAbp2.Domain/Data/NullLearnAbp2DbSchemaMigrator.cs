using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace LearnAbp2.Data
{
    /* This is used if database provider does't define
     * ILearnAbp2DbSchemaMigrator implementation.
     */
    public class NullLearnAbp2DbSchemaMigrator : ILearnAbp2DbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}