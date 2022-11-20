using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using HelloWord.Data;
using Volo.Abp.DependencyInjection;

namespace HelloWord.EntityFrameworkCore;

public class EntityFrameworkCoreHelloWordDbSchemaMigrator
    : IHelloWordDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreHelloWordDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the HelloWordDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<HelloWordDbContext>()
            .Database
            .MigrateAsync();
    }
}
