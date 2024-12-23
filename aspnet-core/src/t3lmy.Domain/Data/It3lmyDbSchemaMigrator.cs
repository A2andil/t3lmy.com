using System.Threading.Tasks;

namespace t3lmy.Data;

public interface It3lmyDbSchemaMigrator
{
    Task MigrateAsync();
}
