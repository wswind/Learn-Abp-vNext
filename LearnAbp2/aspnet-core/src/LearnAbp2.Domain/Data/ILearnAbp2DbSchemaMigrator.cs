using System.Threading.Tasks;

namespace LearnAbp2.Data
{
    public interface ILearnAbp2DbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
