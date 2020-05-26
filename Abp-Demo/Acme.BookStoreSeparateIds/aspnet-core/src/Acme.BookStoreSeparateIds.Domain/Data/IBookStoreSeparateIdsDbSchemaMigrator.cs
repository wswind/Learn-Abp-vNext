using System.Threading.Tasks;

namespace Acme.BookStoreSeparateIds.Data
{
    public interface IBookStoreSeparateIdsDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
