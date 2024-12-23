using Volo.Abp.Modularity;

namespace t3lmy.com;

public abstract class comApplicationTestBase<TStartupModule> : comTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
