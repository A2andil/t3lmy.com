using Volo.Abp.Modularity;

namespace t3lmy.com;

[DependsOn(
    typeof(comDomainModule),
    typeof(comTestBaseModule)
)]
public class comDomainTestModule : AbpModule
{

}
