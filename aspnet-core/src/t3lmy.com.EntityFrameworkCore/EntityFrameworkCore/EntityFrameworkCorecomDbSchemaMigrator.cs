using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using t3lmy.com.Data;
using Volo.Abp.DependencyInjection;

namespace t3lmy.com.EntityFrameworkCore;

public class EntityFrameworkCorecomDbSchemaMigrator
    : IcomDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCorecomDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the comDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<T3lmyDbContext>()
            .Database
            .MigrateAsync();
    }
}
