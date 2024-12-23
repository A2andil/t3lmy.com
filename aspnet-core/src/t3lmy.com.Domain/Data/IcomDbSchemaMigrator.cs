using System.Threading.Tasks;

namespace t3lmy.com.Data;

public interface IcomDbSchemaMigrator
{
    Task MigrateAsync();
}
