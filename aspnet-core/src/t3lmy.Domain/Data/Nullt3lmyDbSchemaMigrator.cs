using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace t3lmy.Data;

/* This is used if database provider does't define
 * It3lmyDbSchemaMigrator implementation.
 */
public class Nullt3lmyDbSchemaMigrator : It3lmyDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
