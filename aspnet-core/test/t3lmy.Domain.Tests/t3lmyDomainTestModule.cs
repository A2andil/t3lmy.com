using Volo.Abp.Modularity;

namespace t3lmy;

[DependsOn(
    typeof(t3lmyDomainModule),
    typeof(t3lmyTestBaseModule)
)]
public class t3lmyDomainTestModule : AbpModule
{

}
