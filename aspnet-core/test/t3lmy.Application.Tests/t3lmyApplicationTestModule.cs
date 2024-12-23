using Volo.Abp.Modularity;

namespace t3lmy;

[DependsOn(
    typeof(t3lmyApplicationModule),
    typeof(t3lmyDomainTestModule)
)]
public class t3lmyApplicationTestModule : AbpModule
{

}
