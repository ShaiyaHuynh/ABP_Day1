using System.Threading.Tasks;

namespace HelloWord.Data;

public interface IHelloWordDbSchemaMigrator
{
    Task MigrateAsync();
}
