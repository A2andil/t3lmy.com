using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using t3lmy.Data;
using Volo.Abp.DependencyInjection;

namespace t3lmy.EntityFrameworkCore;

public class EntityFrameworkCoret3lmyDbSchemaMigrator
    : It3lmyDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoret3lmyDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the t3lmyDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<t3lmyDbContext>()
            .Database
            .MigrateAsync();
    }
}
