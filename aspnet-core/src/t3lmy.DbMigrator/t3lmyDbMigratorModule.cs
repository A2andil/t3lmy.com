using t3lmy.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace t3lmy.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(t3lmyEntityFrameworkCoreModule),
    typeof(t3lmyApplicationContractsModule)
    )]
public class t3lmyDbMigratorModule : AbpModule
{
}
