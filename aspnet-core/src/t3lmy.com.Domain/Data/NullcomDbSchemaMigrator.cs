using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace t3lmy.com.Data;

/* This is used if database provider does't define
 * IcomDbSchemaMigrator implementation.
 */
public class NullcomDbSchemaMigrator : IcomDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
