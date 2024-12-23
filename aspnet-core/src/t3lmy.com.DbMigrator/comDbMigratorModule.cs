using t3lmy.com.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace t3lmy.com.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(comEntityFrameworkCoreModule),
    typeof(comApplicationContractsModule)
    )]
public class comDbMigratorModule : AbpModule
{
}
