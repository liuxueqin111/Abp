using System.Threading.Tasks;

namespace my.bookstore.Data
{
    public interface IbookstoreDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
