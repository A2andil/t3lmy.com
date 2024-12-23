using Volo.Abp.Modularity;

namespace t3lmy.com;

[DependsOn(
    typeof(comApplicationModule),
    typeof(comDomainTestModule)
)]
public class comApplicationTestModule : AbpModule
{

}
