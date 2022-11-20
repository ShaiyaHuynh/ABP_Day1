using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace HelloWord.Data;

/* This is used if database provider does't define
 * IHelloWordDbSchemaMigrator implementation.
 */
public class NullHelloWordDbSchemaMigrator : IHelloWordDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
